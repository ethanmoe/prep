using System;
using System.Collections.Generic;

namespace code.prep.movies
{
  public class MovieLibrary
  {
    readonly IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return movies;
    }

    public void add(Movie movie)
    {
            
            for (int i = 0; i < this.movies.Count; i++)
            {
                if (this.movies[i].title != movie.title)
                {
                    movies.Add(movie);
                }

            }
          
            
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
            List<Movie> c = new List<Movie>();
            for (int i = 0; i < this.movies.Count; i++)
            {
                if (this.movies[i].title != movie.title)
                {
                    movies.Add(movie);
                }

            }
            throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
            List<Movie> c = new List<Movie>();
            for (int i = 0; i < this.movies.Count; i++)
            {
                if (this.movies[i].date_published.Year > year)
                {
                    c.Add(this.movies[i]);
                }

            }
            return c;
            //throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_action_movies()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}
