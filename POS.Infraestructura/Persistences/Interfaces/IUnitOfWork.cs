﻿using POS.Infraestructura.FileStorage;

namespace POS.Infraestructura.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaración o matricula de nuestra interfaces a nivel de repository
        ICategoryRepository Category { get; }
        IUserRepository User { get; }
        IAzureStorage Storage { get; }
        IProviderRepository Provider { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}