namespace MapsterPoc.Mappers;

public interface IMapper<TSrc, TDest>
{
    public TDest Map(TSrc soruce);
    public TDest Map(TSrc source, TDest destionation); 
}
