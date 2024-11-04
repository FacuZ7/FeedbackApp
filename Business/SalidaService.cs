using Entity;
using Entity.Interfaces;

namespace Business
{
    public class SalidaService : IGenericCRUD<Salida>
    {
        private readonly IGenericCRUD<Salida> _salidaRepository;

        public SalidaService(IGenericCRUD<Salida> salidaRepository)
        {
            _salidaRepository = salidaRepository;
        }

        public void Add(Salida entity)
        {
            if(entity.Establecimiento == null)
            {
                throw new Exception(Constantes.Strings.DatoRequerido("Establecimiento"));
            }
            _salidaRepository.Add(entity);
            throw new NotImplementedException();
        }

        public void Delete(Salida entity)
        {
            throw new NotImplementedException();
        }

        public Salida GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Salida entity)
        {
            throw new NotImplementedException();
        }
    }
}
