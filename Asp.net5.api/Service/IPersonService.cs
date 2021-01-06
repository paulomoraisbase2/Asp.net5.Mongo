using Asp.net5.api.Model;
using System;
using System.Collections.Generic;

namespace Asp.net5.api.Service
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person Update(Person person);
        Person FindAllById(long Id);
        List<Person> FindAll();
        void Delete(long Id);
    }
}
