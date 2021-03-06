﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.IDAL
{
    public interface IUnitOfWork : IDisposable
    {
        //add IRepositor|Entity| GetIRepository|Entity| method to get repository for an entity
        
        ICinemaRepository GetICinemaRepository();
        ICinemaCommentRepository GetICinemaCommentRepository();
        ICinemaRatingRepository GetICinemaRatingRepository();
        IFilmRepository GetIFilmRepository();
        IFilmCommentRepository GetIFilmCommentRepository();
        IFilmRatingRepository GetIFilmRatingRepository();
        IHallRepository GetIHallRepository();
        IRoleRepository GetIRoleRepository();
        ISeatRepository GetISeatRepository();
        ISessionRepository GetISessionRepository();
        ITicketReserveRepository GetITicketReserveRepository();
        IUserRepository GetIUserRepository();
        IAuthenticationRepository GetIAuthenticationRepository();
        IUsersToRoleRepository GetIUsersToRoleRepository();

        void Save();
    }
}
