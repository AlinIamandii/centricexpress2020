# centricexpress2020
# Step 1 Create an Web API project
### Pentru a crea un proiect web API trebuie urmati urmatorii pasi
1. Cream o solutie goala.
	1.File -> new Project -> alegem Blank Solution si ii dam un nume sugestiv (CentricExpress2020)
2. Adaugam un nou proiect in solutie
	1.Click dreapta pe solutie -> Add -> New Project -> Alegem ca template **ASP.NET Core Web Application** cu numele **Movies.WebApi** -> alegem template-ul API
3. Adaugam un model pentru film
	1. Click dreapta pe proiectul creat anterior -> Add -> New folder -> numim folderul **Models**
	2. Click dreapta pe folderul Models -> Add -> Alegem Class si ii punem numele **Movie**
	3. Adaugam proprietatile unui film in clasa Movie.cs (Id, Title, etc)
4. Adaugam un controller pentru filme
	1. Click dreapta pe folderul Controllers -> Add -> Controller -> Alegem API Controller-Empty si il numim **MoviesController**
	2. Adaugam o lista de filme pe care le putem returna, deoarece inca nu avem conexiune la baza de date
	3. Adaugam o metoda **Get** pe care punem adnotarea [HttpGet] - pentru a returna filmele
	4. Adaugam o metoda **Create** pe care punem adnotarea [HttpPost] - pentru a adauga un film nou
5. Pentru a vizualiza mai usor adaugam un pachet
	1. Click dreapta pe proiect -> Manage nuget packages -> Swashbuckle.AspNetCore
	2. In Startup inregistram swager in servicii 
	
		```
		services.AddSwaggerGen(s =>
		{
			s.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" }); 
		});	
		```
	3. In Startup configuram swager
	
		``` 
		app.UseSwagger();
		app.UseSwaggerUI(c =>
		{
			c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
		});
		```

### Pentru a crea un proiect MVC trebuie urmati urmatorii pasi
1. Adaugam un nou proiect in solutie
	1.Click dreapta pe solutie -> Add -> New Project -> Alegem ca template **ASP.NET Core Web Application** cu numele **Movies.MVC** -> alegem template-ul Web Application (Model-View-Controller)
2. Adaugam un model pentru film
	1. Click dreapta pe folderul Models -> Add -> Alegem Class si ii punem numele **Movie**
	2. Adaugam proprietatile unui film in clasa Movie.cs (Id, Title, etc)
3. Adaugam un controller pentru filme
	1. Click dreapta pe folderul Controllers -> Add -> Controller -> Alegem MVC Controller-Empty si il numim **MoviesController**
	2. Adaugam o lista de filme pe care le putem returna, deoarece inca nu avem conexiune la baza de date
	3. Adaugam o metoda(actiune) **MoviesOverview**
	4. Adaugam o metoda(actiune) **Create** 
4. Adaugam view-uri  - view-urile trebuie sa aiba aceleasi nume ca si actiunile pentru care sunt create
	1. click dreapta pe folderul Models -> New Folder si il numim Movies
	2. Click drepata pe folderul Movies -> add -> View -> il numim **Create** -> la template alegem Create -> la model class alegem Movie
	3. Click drepata pe folderul Movies -> add -> View -> il numim **MoviesOverview** -> la template alegem List -> la model class alegem Movie
