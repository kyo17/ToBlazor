using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToBlazor.Models;

namespace ToBlazor.Interfaces
{
    public interface IAnimal
    {
        Task<IEnumerable<VideoJuego>> getAll();
        Task<VideoJuego> getById(string id);
        Task save(VideoJuego animal);
        Task update(VideoJuego animal);
        Task delete(string id);
    }
}
