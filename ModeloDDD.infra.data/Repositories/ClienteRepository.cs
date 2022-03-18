using ModeloDDD.domain.entities;
using ModeloDDD.domain.interfaces;
using System;

namespace ModeloDDD.infra.data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
