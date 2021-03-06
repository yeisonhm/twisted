using System;
using Iesi.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcApplication1.Dominio.Model
{
	[Serializable]
	public partial class Persona
	{
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Apellido")]
		public virtual string Apellido
		{
			get;
			set;
		}

        [Required]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Formato email: ejemplo@twisted.com")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email")]
		public virtual string Email
		{
			get;
			set;
		}

        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Estatus")]
		public virtual string Estatus
		{
			get;
			set;
		}

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Fecha Nacimiento")]
		public virtual DateTime FechaNacimiento
		{
			get;
			set;
		}
		public virtual string Nickname
		{
			get;
			set;
		}
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Nombre")]
		public virtual string Nombre
		{
			get;
			set;
		}
        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Privacidad")]
		public virtual string Privacidad
		{
			get;
			set;
		}
		public virtual string Twitter
		{
			get;
			set;
		}
		public virtual ISet<Amistad> Amistads
		{
			get;
			set;
		}
		public virtual ISet<Amistad> Amistads1
		{
			get;
			set;
		}
		public virtual ISet<Comentario> Comentarios
		{
			get;
			set;
		}
		public virtual ISet<Participante> Participantes
		{
			get;
			set;
		}
		
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Persona);
		}
		
		public virtual bool Equals(Persona obj)
		{
			if (obj == null) return false;

			if (Equals(Apellido, obj.Apellido) == false)
				return false;

			if (Equals(Email, obj.Email) == false)
				return false;

			if (Equals(Estatus, obj.Estatus) == false)
				return false;

			if (Equals(FechaNacimiento, obj.FechaNacimiento) == false)
				return false;

			if (Equals(Nickname, obj.Nickname) == false)
				return false;

			if (Equals(Nombre, obj.Nombre) == false)
				return false;

			if (Equals(Privacidad, obj.Privacidad) == false)
				return false;

			if (Equals(Twitter, obj.Twitter) == false)
				return false;

			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (Apellido != null ? Apellido.GetHashCode() : 0);
			result = (result * 397) ^ (Email != null ? Email.GetHashCode() : 0);
			result = (result * 397) ^ (Estatus != null ? Estatus.GetHashCode() : 0);
			result = (result * 397) ^ (FechaNacimiento != null ? FechaNacimiento.GetHashCode() : 0);
			result = (result * 397) ^ (Nickname != null ? Nickname.GetHashCode() : 0);
			result = (result * 397) ^ (Nombre != null ? Nombre.GetHashCode() : 0);
			result = (result * 397) ^ (Privacidad != null ? Privacidad.GetHashCode() : 0);
			result = (result * 397) ^ (Twitter != null ? Twitter.GetHashCode() : 0);			
			return result;
		}
	}
}