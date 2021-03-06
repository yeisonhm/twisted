using System;
using Iesi.Collections.Generic;

namespace MvcApplication1.Dominio.Model
{
	[Serializable]
	public partial class Comentario
	{
		public virtual string Descripcion
		{
			get;
			set;
		}
		public virtual DateTime Fecha
		{
			get;
			set;
		}
		public virtual int IdDestino
		{
			get;
			set;
		}
		public virtual string Nickname
		{
			get;
			set;
		}
		public virtual Destino Destino
		{
			get;
			set;
		}
		public virtual Persona Persona
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Comentario);
		}
		
		public virtual bool Equals(Comentario obj)
		{
			if (obj == null) return false;

			if (Equals(Descripcion, obj.Descripcion) == false)
				return false;

			if (Equals(Fecha, obj.Fecha) == false)
				return false;

			if (Equals(IdDestino, obj.IdDestino) == false)
				return false;

			if (Equals(Nickname, obj.Nickname) == false)
				return false;

			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (Descripcion != null ? Descripcion.GetHashCode() : 0);
			result = (result * 397) ^ (Fecha != null ? Fecha.GetHashCode() : 0);
			result = (result * 397) ^ (IdDestino != null ? IdDestino.GetHashCode() : 0);
			result = (result * 397) ^ (Nickname != null ? Nickname.GetHashCode() : 0);			
			return result;
		}
	}
}