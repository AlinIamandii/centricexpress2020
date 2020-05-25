# centricexpress2020

Pentru adaugarea testelor unitare urmatorii pasi au fost realizati:

1. Se adauga un nou proiect: Click dreapta pe solutie -> Add -> New Project -> Se alege ca template NUnit Test Project (.NetCore) -> Next -> Dam un nume sugestiv proiectului de teste (Movies.Business.Tests) -> Create

2. Adaugam pachetele care ne vor ajuta in scrierea unit testelor:

    2.1 FluentAssertions -> pentru scrierea asertiunilor  intr-un mod fluent
	
	2.2 Moq -> pentru a moq-ui dependintele externe

3. Adaugam clasa de test: Click dreapta pe proiect -> Add -> New Item -> Class -> Ii dam un nume sugestiv (MovieBusinessTest.cs)

4. Adaugam metodele de SetUp si Teardown

5. Adaugam metodele de test (adnotate cu [Test]) urmarind pattern-ul Arrange-Act-Assert

Pentru rularea testelor ne putem folosi de fereastra "Test Explorer" din Visual Studio.