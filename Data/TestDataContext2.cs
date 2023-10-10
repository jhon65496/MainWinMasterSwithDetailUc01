using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
// using MainWinMasterUcDetailUcSwithFrm02.Abstractions;
// using MainWinMasterUcDetailUcSwithFrm02.Models;
using MainWinMasterUcDetailUcSwithFrm02;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace MainWinMasterUcDetailUcSwithFrm02.Data
{
    class TestDataContext2
    {
        // private readonly List<MenuItem> _people;

        //public ObservableCollection<MenuItem> MenuItems { get; set; }
        ////ctor
        //public TestDataContext()
        //{


        //    MenuItems = new ObservableCollection<MenuItem>()
        //    {
        //        new MenuItem {Name = "Страница 1", NameVm = "FirstPageViewModel", State  = "Статус1"},
        //        new MenuItem {Name = "Страница 2", NameVm = "SecondPageViewModel", State = "Статус1"}
        //    };

        //}


        //public Task<IEnumerable<Person>> GetPeopleAsync()
        //{
        //    List<Person> people = new List<Person>();
        //    foreach (var p in _people)
        //    {
        //        var person = new Person
        //        {
        //            Id = p.Id,
        //            FirstName = p.FirstName,
        //            LastName = p.LastName,
        //            Birthdate = p.Birthdate
        //        };
        //        people.Add(person);
        //    }

        //    return Task.FromResult(people.AsEnumerable());
        //}

        //public Task<IEnumerable<MenuItem>> GetMenuItemsAsync()
        //{   
        //    return Task.FromResult(MenuItems.AsEnumerable());
        //}

        //public Task RemovePerson(int id)
        //{
        //    if (id == 0) throw new ArgumentException(nameof(id));

        //    var person = _people.SingleOrDefault(p => p.Id == id);
        //    if (person == null)
        //    {
        //        Trace.WriteLine($"Не удалось найти чела с id={id} для удаления.");
        //        return Task.FromResult(0);
        //    }

        //    _people.Remove(person);
        //    return Task.FromResult(1);
        //}

        //public Task SavePersonAsync(Person currentPerson)
        //{
        //    if (currentPerson == null)
        //        throw new ArgumentNullException(nameof(currentPerson));

        //    if (currentPerson.Id == 0)
        //    {
        //        AddPerson(currentPerson);
        //    }
        //    else
        //    {
        //        UpdatePerson(currentPerson);
        //    }

        //    return Task.FromResult(1);
        //}

        //private void AddPerson(Person currentPerson)
        //{
        //    if (_people.Any())
        //    {
        //        currentPerson.Id = _people.Max(p => p.Id) + 1;
        //    }
        //    else
        //    {
        //        currentPerson.Id = 1;
        //    }

        //    _people.Add(currentPerson);
        //}

        //private void UpdatePerson(Person currentPerson)
        //{
        //    var person = _people.SingleOrDefault(p => p.Id == currentPerson.Id);
        //    if (person == null)
        //    {
        //        Trace.WriteLine($"Не удалось найти чела с id={currentPerson.Id} для обновления.");
        //        return;
        //    }

        //    person.FirstName = currentPerson.FirstName;
        //    person.LastName = currentPerson.LastName;
        //    person.Birthdate = currentPerson.Birthdate;
        //}
    }
}
