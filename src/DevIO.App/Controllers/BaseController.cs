﻿using Microsoft.AspNetCore.Mvc;
using DevIO.Business.Interfaces;

namespace DevIO.App.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly INotificador _notificador;

        protected BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida() => !_notificador.TemNotificacao();
    }
}
