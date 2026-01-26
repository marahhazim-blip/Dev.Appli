namespace DemoAPIs.ApiHello.DTOs
{
    public class SomeoneRequest
    {
        private string _firstname;

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        // GET / SET fonctionnera mais peut amener à des soucis de modification de termes de recherches
        public string Lastname { get; private set; }

        // On privilégie donc GET / INIT de sorte à ne pas pouvoir modifier les valeurs de recherches 
        public string Team { get; init; }

        public SomeoneRequest(string firstname)
        {
            _firstname = firstname;
        }
    }

    // Normalement, pour faire des DTOs, on privilégie un mécanisme non modifiable, 'immutable'. Pour cela, le plus simple,
    // depuis le C# 7+, est d'utiliser les records
    public record SomeoneRequestRecord(string Firstname, string Lastname, string Team);
}
