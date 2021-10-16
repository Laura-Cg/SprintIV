using System.Threading;
using ProySprintIII.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProySprintIII.Server.Storage;

namespace ProySprintIII.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ActorsController: ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IFilesStorageClass FilesStorage;
        private readonly string carpeta = "actors";

        public ActorsController (ApplicationDbContext context,IFilesStorageClass filesStorage) {
        this.context = context;
        this.FilesStorage = filesStorage;
    }
        [HttpPost]
        public async Task<ActionResult<int>> Post (Cast cast) {
            if(!string.IsNullOrWhiteSpace(cast.ActorImage))
            {
                var actor_photo = Convert.FromBase64String(cast.ActorImage);
                cast.ActorImage = await FilesStorage.SaveFile(actor_photo,".jpg", carpeta);
            }
            context.Add(cast);
            await context.SaveChangesAsync();
            return cast.Id;

        }
    }
}