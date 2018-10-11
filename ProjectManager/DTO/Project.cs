using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DTO
{
    [Table(Name = "Project")]
    public class Project : INotifyPropertyChanged
    {
        [Column(Name = "ID", DbType = "char(6)", CanBeNull = false, IsPrimaryKey = true)]
        public int id { get; set; }
        [Column(Name = "Key", DbType = "char(6)", CanBeNull = false)]
        public string key { get; set; }
        [Column(Name = "Name", DbType = "varchar(20)", CanBeNull = false)]
        public string name { get; set; }


        public Project()
        {
        }
        public Project(int id, string key, string name)
        {
            this.id = id;
            this.key = key;
            this.name = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
