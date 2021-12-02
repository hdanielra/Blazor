﻿using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Interfaces
{
    interface IFilmService
    {
        Task<IEnumerable<Film>> GetAllFilms();

        Task<Film> GetDetails(int id);

        Task<bool> InsertFilm(Film film);
        Task<bool> SaveFilm(Film film);
        Task<bool> DeleteFilm(int id);
    }
}
