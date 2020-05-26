# centricexpress2020
## Step 2 - Architecture
### Pentru a transforma solutia aceasta intr-un proiect cu arhitectura 3-layered urmatorii pasi trebuie urmati:

1. Se adauga doua noi proiecte pentru nivelele Business si Data
	1. Click dreapta pe solutie -> Add -> New Project -> Alegem ca template **.NET Core Class Library** cu numele **Movies.Business**
	2. Repetam acelasi proces ca la pasul **1.1.** dar ca nume punem **Movies.Data**.

2. Adaugam referintele necesare pentru a transforma solutie in 3-layered/topdown
	1. Click dreapta pe Dependencies din proiectul **Movies.WebApi** -> Add Project Reference -> Alegem **Movies.Business**.
	2. Click dreapta pe Dependencies din proiectul **Movies.Business** -> Add Project Reference -> Alegem **Movies.Data**.
	
3. In proiectul **Movies.Data** adaugam entitatea `Movie` cu proprietatile ei si clasa `Database` unde vom stoca intr-o lista entitatile.

4. In proiectul **Movies.Business** adaugam model-ul pentru movie si interfata `IMovieBusiness` si implementarea sa `MovieBusiness`

5. In proiectul **Movies.WebApi**:
	1. In fisierul de `Startup` in metoda `ConfigureServices` inregistram serviciul creat in **Movies.Business**.

		`
			services.AddSingleton<IMovieBusiness, MovieBusiness>();
		`
	2. In controller-ul `MoviesController`  folosim functionalitatea expuse de `MovieBusiness` pentru `Get` si `Create`.