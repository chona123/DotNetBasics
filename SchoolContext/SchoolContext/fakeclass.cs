using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bogus;

namespace SchoolContext
{
   public class fakeclass<T> : IFakerTInternal, ILocaleAware, IRuleSet<T> where T : class
    {

       public virtual List<T> Generate(int count, string ruleSets = null)
       {
           return new List<T>();
       }
           


        //public IBinder Binder
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //public Faker FakerHub
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //public int? LocalSeed
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //public Type TypeOfT
        //{
        //    get { throw new NotImplementedException(); }
        //}
        IBinder IFakerTInternal.Binder
        {
            get { throw new NotImplementedException(); }
        }

        Faker IFakerTInternal.FakerHub
        {
            get { throw new NotImplementedException(); }
        }

        int? IFakerTInternal.LocalSeed
        {
            get { throw new NotImplementedException(); }
        }

        Type IFakerTInternal.TypeOfT
        {
            get { throw new NotImplementedException(); }
        }

        public string Locale
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Faker<T> CustomInstantiator(Func<Faker, T> factoryMethod)
        {
            throw new NotImplementedException();
        }

        public Faker<T> FinishWith(Action<Faker, T> action)
        {
            throw new NotImplementedException();
        }

        public Faker<T> Ignore<TPropertyOrField>(System.Linq.Expressions.Expression<Func<T, TPropertyOrField>> propertyOrField)
        {
            throw new NotImplementedException();
        }

        public Faker<T> RuleFor<TProperty>(System.Linq.Expressions.Expression<Func<T, TProperty>> property, TProperty value)
        {
            throw new NotImplementedException();
        }

        public Faker<T> RuleFor<TProperty>(System.Linq.Expressions.Expression<Func<T, TProperty>> property, Func<TProperty> valueFunction)
        {
            throw new NotImplementedException();
        }

        public Faker<T> RuleFor<TProperty>(System.Linq.Expressions.Expression<Func<T, TProperty>> property, Func<Faker, TProperty> setter)
        {
            throw new NotImplementedException();
        }

        public Faker<T> RuleFor<TProperty>(System.Linq.Expressions.Expression<Func<T, TProperty>> property, Func<Faker, T, TProperty> setter)
        {
            throw new NotImplementedException();
        }

        public Faker<T> Rules(Action<Faker, T> setActions)
        {
            throw new NotImplementedException();
        }

        public Faker<T> StrictMode(bool ensureRulesForAllProperties)
        {
            throw new NotImplementedException();
        }
    }
}

