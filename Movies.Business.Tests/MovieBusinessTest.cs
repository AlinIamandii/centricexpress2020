using System;
using System.Collections.Generic;
using FluentAssertions;
using Moq;
using Movies.Business.Model;
using Movies.Data;
using Movies.Data.Entities;
using NUnit.Framework;

namespace Movies.Business.Tests
{
    public class MovieBusinessTest
    {
        private MovieBusiness _systemUnderTest;
        private Mock<IMovieRepository> _movieRepositoryMock;
        private MockRepository _mockRepository;

        [SetUp]
        public void SetUp()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _movieRepositoryMock = _mockRepository.Create<IMovieRepository>();

            _systemUnderTest = new MovieBusiness(_movieRepositoryMock.Object);
        }

        [Test]
        public void Given_Get_When_IsCalled_Then_Should_Return_TheListOfMovies()
        {
            // Arrange
            var movie = new Movie
            {
                Id = Guid.Parse("EA281841-A810-4C06-8418-0B25E1F66AFA"),
                HasWonOscar = true,
                Rating = 7,
                Title = "My movie",
                Year = 2030
            };
            var movies = new List<Movie> { movie };
            var expectedResult = new List<MovieModel>
            {
                new MovieModel
                {
                    HasWonOscar = movie.HasWonOscar,
                    Id = movie.Id,
                    Rating = movie.Rating,
                    Title = movie.Title,
                    Year = movie.Year,
                    Characters = new List<CharacterModel>()
                }
            };
            _movieRepositoryMock.Setup(r => r.Get())
                .Returns(movies);

            // Act
            var result = _systemUnderTest.Get();

            // Assert
            result.Should()
                .BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Given_Add_When_IsCalled_Then_Should_VerifyAll()
        {
            // Arrange
            var movieModel = new MovieModel
            {
                HasWonOscar = false,
                Id = Guid.Parse("68066711-F228-44F0-AE73-6257D2B191D9"),
                Rating = 8.6,
                Title = "Test title",
                Year = 1977
            };
            _movieRepositoryMock.Setup(r => r.Add(It.IsAny<Movie>()))
                .Verifiable();

            // Act && Assert
            _systemUnderTest.Add(movieModel);
        }

        [TearDown]
        public void TearDown()
        {
            _mockRepository.VerifyAll();
            _systemUnderTest = null;
        }
    }
}