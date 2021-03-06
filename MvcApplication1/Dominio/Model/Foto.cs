using System;
using Iesi.Collections.Generic;

namespace MvcApplication1.Dominio.Model
{
	[Serializable]
	public partial class Foto
	{
		public virtual string Descripcion
		{
			get;
			set;
		}
		public virtual int IdFoto
		{
			get;
			set;
		}
		public virtual string Nombre
		{
			get;
			set;
		}
		public virtual string Url
		{
			get;
			set;
		}
		public virtual Viaje Viaje
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Foto);
		}
		
		public virtual bool Equals(Foto obj)
		{
			if (obj == null) return false;

			if (Equals(Descripcion, obj.Descripcion) == false)
				return false;

			if (Equals(IdFoto, obj.IdFoto) == false)
				return false;

			if (Equals(Nombre, obj.Nombre) == false)
				return false;

			if (Equals(Url, obj.Url) == false)
				return false;

			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (Descripcion != null ? Descripcion.GetHashCode() : 0);
			result = (result * 397) ^ (IdFoto != null ? IdFoto.GetHashCode() : 0);
			result = (result * 397) ^ (Nombre != null ? Nombre.GetHashCode() : 0);
			result = (result * 397) ^ (Url != null ? Url.GetHashCode() : 0);			
			return result;
		}
	}
}