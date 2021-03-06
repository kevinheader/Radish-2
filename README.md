

### What is Radish? <img src="https://raw.github.com/AlexanderKrutov/Radish/master/icon.png" width="48">
Radish is a simple .Net library that allows you to auto-generate HTML-documentation for your REST API on the basis of attributes in the source code.
Radish is an acronym that means **R**EST **A**PI **D**ocumentation **I**n the **S**ource to **H**tml.

### NuGet Package [![NuGet Status](http://img.shields.io/nuget/v/Radish.svg?style=flat)](https://www.nuget.org/packages/Radish/)
```
PM> Install-Package Radish
```

### Features
- you do not need to create REST API documentation manually;
- you do not need to sync your documentation file with changes in the code, as it needed for other popular generators, like [Swagger] or [ApiBlueprint];
- unlike the [ASP.NET Web API Help Page] solution, Radish does not require [WebHost], [Mvc] and [Razor] libraries, and suits for small self-hosting RESTful servers;
- all documentation is a single HTML-page with CSS and JavaScript embedded.

Writing documentation in the source code with Radish looks like:

```csharp
// Documentation starts here
[Order("pets", 2)]
[Method("GET", "/api/pets/<id>", "pet-get-by-id")]
[MethodTitle("Get pet")]
[MethodDescription("Returns Pet object by specified id.")]
[RequestParameter("id", "Integer", "Id of the Pet")]
[ResponseBodyDescription("Json-serialized Pet object")]
[ResponseBodyExample(@"{""Id"":1, ""AnimalType"":""Cat"",""Name"":""Lisa"",""Breed"":""Turkish Angora"",""Age"":2,""Color"":""White""}")]
[ResponseCode(200, "OK. On successful result.")]
[ResponseCode(404, "Not Found. When pet with specified id was not found.")]
// Documentation ends here

[HttpGet]
[Route("pets/{petId:long}")]
[ResponseType(typeof(Pet))]
public IHttpActionResult GetPet(int petId)
{
	Pet pet = DataBase.Instance.GetPet(petId);
	if (pet == null)
	{
		return this.NotFound(String.Format("Pet with id = {0} not found.", petId));
	}
	return Ok(pet);
}
```

Radish uses own simple template engine to create HTML documentation page, and you can freely customize its output.
Let's take a look on the output documentation examples ([example 1], [example 2]) for [this simple demo].
Also check [the guide] how to use Radish.

### License
Radish is licensed under Apache 2.0 license.  

### Credits
Radish icon created by [Creative Stall] from [Noun Project].

[Swagger]:http://swagger.io/
[ApiBlueprint]:https://apiblueprint.org/
[ASP.NET Web API Help Page]:http://www.nuget.org/packages/Microsoft.AspNet.WebApi.HelpPage
[WebHost]:http://www.nuget.org/packages/Microsoft.AspNet.WebApi.WebHost/
[Mvc]:http://www.nuget.org/packages/Microsoft.AspNet.Mvc/
[Razor]:http://www.nuget.org/packages/Microsoft.AspNet.Razor/
[example 1]:https://cdn.rawgit.com/AlexanderKrutov/Radish/master/Radish.Demo.Output/Simple.html
[example 2]:https://cdn.rawgit.com/AlexanderKrutov/Radish/master/Radish.Demo.Output/Bootstrap.html
[this simple demo]:https://github.com/AlexanderKrutov/Radish/tree/master/Radish.Demo
[the guide]:https://github.com/AlexanderKrutov/Radish/wiki
[Creative Stall]:https://thenounproject.com/creativestall/
[Noun Project]:https://thenounproject.com/
