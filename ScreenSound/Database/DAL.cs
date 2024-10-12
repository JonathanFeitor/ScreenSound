using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Database
{
    internal class DAL<T> where T : class
    {
        protected readonly ScreenSoundContext context;

        public DAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> List()
        {
            return context.Set<T>().ToList();
        }

        public void AddValue(T objectValue)
        {
            context.Set<T>().Add(objectValue);
            context.SaveChanges();
        }


        public void UpdateValue(T objectValue)
        {
            context.Set<T>().Update(objectValue);
            context.SaveChanges();
        }
        public void DeleteValue(T objectValue)
        {
            context.Set<T>().Remove(objectValue);
            context.SaveChanges();
        }

        public T? RecoveryByObject(Func<T, bool> condiction)
        {
            return context.Set<T>().FirstOrDefault(condiction);
        }

    }

}
