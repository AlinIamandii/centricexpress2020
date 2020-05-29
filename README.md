* Adaugare lista de caractere pentru un film, relatie one to many:
   1. Creare entitate Character, pe langa proprietatile de baza(Id, Name) adaugam si urmatoarele proprietati: 
          public Guid MovieId { get; set; }
          public Movie Movie { get; set; }

   2. Adaugam lista de Caractere ca si proprietate in clasa Movie.cs
     Pasi de la punctele 1 si 2 construiesc o relatie complet definita in ambele parti, care va crea o relatie one-to-many in baza de date.
   3. Adaugam noua entitate creata, Character, la colectia de DbSet-uri din DatabaseContext
             public DbSet<Character> Characters { get; set; }
       Note: Au fost adaugate si date initilae pentru Charactere, a caror proprietate MovieId trebuie sa fie deja existenta in tabela Movies pentru a putea construi relatia.
    4. Cream o noua migrare la baza de date pentru a actualiza schema bazei de date cu noua tabela .

    5. Facem update la baza de date.

    6. Actializam metoda de Get din MovieRepository.cs pentru a inlclude pentru un film si caracrele acestuia.

    7. Pentru a fi vizibila lista de caractere cand facem apelul din swagger adaugam si lisa de caractere la obiectul intor in metoda de get din MobieBusiness.cs
  
