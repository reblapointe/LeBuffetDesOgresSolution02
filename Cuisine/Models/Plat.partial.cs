﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cuisine.Models
{
    public partial class Plat
    {
        public override bool Equals(object obj)
        {
            return obj is Plat plat &&
                   PlatId == plat.PlatId &&
                   DateCreation == plat.DateCreation &&
                   Taille == plat.Taille &&
                   EqualityComparer<TypePlat>.Default.Equals(TypePlat, plat.TypePlat);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(PlatId, DateCreation, Taille, TypePlat);
        }

        public override string ToString()
        {
            return $"[{PlatId},{DateCreation},{Taille},{TypePlat?.Nom}]";
        }
    }
}
