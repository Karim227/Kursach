using Cyrsovay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyrsovay.Models.Primer
{
    public static class Test
    {
        public static void Initialize(BTGPContext context)
        {
                context.Cyrsach.AddRange(
                    new BTGPModel
                    {
                        Name = "Карим",
                        Familia = "Габибов",
                        Otchestvo = "Чего-то там Оглы",
                        Speciality = "Информатика",
                        State = "Учится",
                        Cyrs = "И-3А"
                    }
                );
                context.SaveChanges();
        }
    }
}
