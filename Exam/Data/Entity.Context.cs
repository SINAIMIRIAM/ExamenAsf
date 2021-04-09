﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BOLSA_EXAMENEntities : DbContext
    {
        public BOLSA_EXAMENEntities()
            : base("name=BOLSA_EXAMENEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DATOS_PERSONALES> DATOS_PERSONALES { get; set; }
        public virtual DbSet<EXP_LABORAL> EXP_LABORAL { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual ObjectResult<ALL_USERS_Result> ALL_USERS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_USERS_Result>("ALL_USERS");
        }
    
        public virtual int INSERT_USER(string userName, string pass, string email, string nombre, string paterno, string materno, string ciudad, string calle, string numero, string colonia, string telefono, string otroTelefono, Nullable<System.DateTime> fechaNac, string curp, string rfc, string pasaporte, string cartilla, string genero, string estadoCivil, string municipio, string estado)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("Pass", pass) :
                new ObjectParameter("Pass", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var paternoParameter = paterno != null ?
                new ObjectParameter("Paterno", paterno) :
                new ObjectParameter("Paterno", typeof(string));
    
            var maternoParameter = materno != null ?
                new ObjectParameter("Materno", materno) :
                new ObjectParameter("Materno", typeof(string));
    
            var ciudadParameter = ciudad != null ?
                new ObjectParameter("Ciudad", ciudad) :
                new ObjectParameter("Ciudad", typeof(string));
    
            var calleParameter = calle != null ?
                new ObjectParameter("Calle", calle) :
                new ObjectParameter("Calle", typeof(string));
    
            var numeroParameter = numero != null ?
                new ObjectParameter("Numero", numero) :
                new ObjectParameter("Numero", typeof(string));
    
            var coloniaParameter = colonia != null ?
                new ObjectParameter("Colonia", colonia) :
                new ObjectParameter("Colonia", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var otroTelefonoParameter = otroTelefono != null ?
                new ObjectParameter("OtroTelefono", otroTelefono) :
                new ObjectParameter("OtroTelefono", typeof(string));
    
            var fechaNacParameter = fechaNac.HasValue ?
                new ObjectParameter("FechaNac", fechaNac) :
                new ObjectParameter("FechaNac", typeof(System.DateTime));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var rfcParameter = rfc != null ?
                new ObjectParameter("Rfc", rfc) :
                new ObjectParameter("Rfc", typeof(string));
    
            var pasaporteParameter = pasaporte != null ?
                new ObjectParameter("Pasaporte", pasaporte) :
                new ObjectParameter("Pasaporte", typeof(string));
    
            var cartillaParameter = cartilla != null ?
                new ObjectParameter("Cartilla", cartilla) :
                new ObjectParameter("Cartilla", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            var estadoCivilParameter = estadoCivil != null ?
                new ObjectParameter("EstadoCivil", estadoCivil) :
                new ObjectParameter("EstadoCivil", typeof(string));
    
            var municipioParameter = municipio != null ?
                new ObjectParameter("Municipio", municipio) :
                new ObjectParameter("Municipio", typeof(string));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_USER", userNameParameter, passParameter, emailParameter, nombreParameter, paternoParameter, maternoParameter, ciudadParameter, calleParameter, numeroParameter, coloniaParameter, telefonoParameter, otroTelefonoParameter, fechaNacParameter, curpParameter, rfcParameter, pasaporteParameter, cartillaParameter, generoParameter, estadoCivilParameter, municipioParameter, estadoParameter);
        }
    
        public virtual ObjectResult<SELECT_USER_Result> SELECT_USER(Nullable<int> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SELECT_USER_Result>("SELECT_USER", userIdParameter);
        }
    }
}
