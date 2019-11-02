using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class ComputerStore
    {
        public TGLContext Context { get; set; }
        public ComputerStore(TGLContext context)
        {
            Context = context;
        }

        internal void EditComputer(Computer computer)
        {
            Computer currentcomputer = GetComputerById(computer.Id);
            currentcomputer.Brand = computer.Brand;
            currentcomputer.Model = computer.Model;
            currentcomputer.Cpu = computer.Cpu;
            currentcomputer.Ram = computer.Ram;
            Context.Computer.Update(currentcomputer);
            Context.SaveChanges();
        }
        internal Computer GetComputerById(Guid id)
        {
            return Context.Computer.FirstOrDefault(x => x.Id == id);
        }
        internal void AddComputer(Computer computer)
        {
            Context.Computer.Add(computer);
            Context.SaveChanges();
        }
        internal void DeleteComputer(Guid id)
        {
            var computer = Context.Computer.FirstOrDefault(x => x.Id == id);
            Context.Computer.Remove(computer);
            Context.SaveChanges();
        }
        public List<Computer> GetComputer()
        {
            return Context.Computer.ToList();
        }
    }
}
