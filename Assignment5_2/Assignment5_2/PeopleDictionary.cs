using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_2
{
    internal class PeopleDictionary : IDictionary<PeopleEnum, Person>
    {
        public Person this[PeopleEnum key] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICollection<PeopleEnum> Keys => throw new NotImplementedException();

        public ICollection<Person> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(PeopleEnum key, Person value)
        {
            throw new NotImplementedException();
        }

        public void Add(KeyValuePair<PeopleEnum, Person> item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<PeopleEnum, Person> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(PeopleEnum key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<PeopleEnum, Person>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<PeopleEnum, Person>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(PeopleEnum key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<PeopleEnum, Person> item)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(PeopleEnum key, [MaybeNullWhen(false)] out Person value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
