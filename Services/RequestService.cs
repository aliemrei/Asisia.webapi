
using System.Text;
using Asisia.webapi.Models.Db;
using Asisia.webapi.Repositories;
using Microsoft.AspNetCore.OData.Results;

namespace Asisia.webapi.Services;

public sealed class RequestService : ServiceBase<Request>
{
    private readonly IGenericService<Person> _personService;
    private readonly IGenericService<Users> _usersService;
    private readonly IGenericService<RequestDetail> _requestDetailService;

    public RequestService(IGenericRepository<Request> _repository, 
        IGenericService<Person> personService,
        IGenericService<Users> usersService,
        IGenericService<RequestDetail> requestDetailService,
        IGenericService<Agency> agencyService) : base(_repository)
    {
        this._personService = personService;
        
        this._usersService = usersService;

        this._requestDetailService = requestDetailService;
    }

    public override Request Create() 
    {
        var result = base.Create();

        result.Curcode = "TRY  ";

        return result;
    }

    public override IQueryable<Request> AddNew()
    {
        List<Request> result = new List<Request>();

        var obj = this.Create();

        obj.Person = _personService.Create();

        obj.AdduserNavigation = new Users();

        var _userId = obj.Adduser;

        var _au = _usersService.GetAll().Where(x => x.Id == _userId).Select(x => new { x.Username, x.Fullname }).FirstOrDefault();

        obj.AdduserNavigation.Username = _au?.Username;

        obj.AdduserNavigation.Fullname = _au?.Fullname;

        result.Add(obj);

        return result.AsQueryable();
    }


    public override Request? Insert(Request obj, System.Text.Json.JsonElement data)
    {
        var delta = this.GetDelta(data);

        var request = Create();

        delta.Patch(request);

        if (request.Person != null)
        {
            if (request.Person.Id != null && request.Person.Id != Guid.Empty)
                request.Personid = request.Person.Id;

            request.Person = null;
        }
        

        request.RequestDetail = null;

        DoPerson(request, data);

        var result = base.Insert(request, data);

        Save();

        DoRequestDetail(request, data);

        return result;
    }

    public override Request? Update(object id, Request changedData, System.Text.Json.JsonElement data)
    {
        var delta = this.GetDelta(data);

        var request = Create();

        delta.Patch(request);

        if (request.Person != null)
        {
            if (request.Person.Id != null && request.Person.Id != Guid.Empty)
                request.Personid = request.Person.Id;

            request.Person = null;
        }
        

        request.RequestDetail = null;

        DoPerson(request, data);

        DoRequestDetail(changedData, data);

        return base.Update(id, changedData, data);
    }

    private bool DoPerson(Request request, System.Text.Json.JsonElement data)
    {
        if (data.TryGetProperty("Person", out var personData))
        {
            var personDelta = _personService.GetDelta(personData);

            if (personData.TryGetProperty("Id", out var id))
            {
                if (_personService.IsExists(id.GetGuid()) == false)
                {
                    var person = _personService.Create();

                    personDelta.Patch(person);

                    if (_personService.ValidateForInsert(person))
                    {
                        _personService.Insert(person, personData);

                        _personService.Save();
                    }
                }
                else 
                {
                    var person = _personService.GetById(id.GetGuid()).Queryable.FirstOrDefault();

                    personDelta.Patch(person);

                    if (_personService.ValidateForUpdate(person))
                    {
                        _personService.Update(person.Id, person, personData);

                        _personService.Save();
                    }
                }
            }

            return true;
        }

        return false;
    }

    private bool DoRequestDetail(Request request, System.Text.Json.JsonElement data) 
    {
        if (data.TryGetProperty("RequestDetail", out var requestDetails))
        {
            
            foreach (var item in requestDetails.EnumerateArray())
            {
                var _ = "updated";

                if (item.TryGetProperty("_", out var e))
                    _ = e.GetString();
                
                if (_ == "inserted")
                {
                    var requestDetailDelta = _requestDetailService.GetDelta(item);

                    var currentData = _requestDetailService.Create();
                   
                    requestDetailDelta.Patch(currentData);

                    if (_requestDetailService.ValidateForInsert(currentData))
                    {
                        _requestDetailService.Insert(currentData, item);

                        _requestDetailService.Save();
                    }
                }
                else if (_ == "deleted")
                {
                    if (item.TryGetProperty("Id", out var id))
                    {
                         
                        _requestDetailService.Delete(id.GetGuid());

                        _requestDetailService.Save();
                    }
                }
                else if (item.TryGetProperty("Id", out var id))
                {
                    var currentData = _requestDetailService.GetById(id.GetGuid()).Queryable.FirstOrDefault();

                    if (currentData != null)
                    {
                        var requestDetailDelta = _requestDetailService.GetDelta(item);

                        requestDetailDelta.Patch(currentData);

                        if (_requestDetailService.ValidateForUpdate(currentData))
                        {
                            _requestDetailService.Update(id.GetGuid(), currentData, item);

                            _requestDetailService.Save();
                        }
                    }
                }
            }

            return true;
        }

        return false;
    }
}