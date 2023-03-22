using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using Android.Text.Format;
using Java.Sql;
using SQLite;
using Xamarin.Forms;
using System.Runtime;

namespace AppFit.Models
{
    public class Atividade
    {
       
  
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

      public string Descricao { get; set; }
      
        public DateTime Data { get; set; }
        public string Hora { get; set; }

        public double? Peso { get; set; }
        public string Observacoes { get; set; }
    }
}