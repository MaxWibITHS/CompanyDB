using Microsoft.AspNetCore.Mvc;

namespace Company.API.Extensions
{
    public static class Extensions
    {
        public static async Task<IResult>HttpGetAsync<TEntity, TDto>(this IDbService db)
            where TEntity : class, IEntity
            where TDto : class
        {
            try
            {
                var entities = await db.GetAsync<TEntity, TDto>();
                return Results.Ok(entities);
            }
            catch { }
            return Results.BadRequest();
        }

        public static async Task<IResult> HttpGetAsync<TEntity, TDto>(this IDbService db, int id)
            where TEntity : class, IEntity
            where TDto : class
            {
            try
            {
                var entity = await db.SingleAsync<TEntity, TDto>(f => f.Id.Equals(id));
                if (entity is null) return Results.BadRequest();
                return Results.Ok(entity);
            }
            catch { }
            return Results.BadRequest();    
            }

        public static async Task<IResult> HttpPostAsync<TEntity, TDto>(this IDbService db, TDto dto)
            where TEntity : class, IEntity
            where TDto : class
        {
            try
            {
                if (dto is null) return Results.BadRequest();
                var entity = await db.AddAsync<TEntity, TDto>(dto);
                if (await db.SaveChangesAsync())
                {
                    var Uri = db.GetURI<TEntity>(entity);
                    return Results.Created(Uri, entity);
                }
            
            }
            catch { }
            return Results.BadRequest();

        }

        public static async Task<IResult> HttpPutAsync<TEntity, TDto>(this IDbService db, TDto dto, int id)
            where TEntity : class, IEntity
            where TDto : class
        {
            try
            {
                if (dto is null) return Results.BadRequest();
                if (!await db.AnyAsync<TEntity>(c => c.Id.Equals(id)))
                    return Results.NotFound();

                db.Update<TEntity, TDto>(id, dto);
                if (await db.SaveChangesAsync())
                    return Results.Ok("Update OK");
            }
                catch { }

                return Results.BadRequest();
            }
        

         public static async Task<IResult>HttpDeleteAsync<TEntity>(this IDbService db, int id)
            where TEntity : class, IEntity
        {
            try
            {
                var ok = await db.DeleteAsync<TEntity>(id);

                if (await db.SaveChangesAsync())
                    return Results.Ok("Item deleted");
            }
            catch { }
            
            return Results.BadRequest();


        }
    }
}
