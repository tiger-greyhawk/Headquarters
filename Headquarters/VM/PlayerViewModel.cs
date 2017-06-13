using Model.DTO;
using System.Collections.ObjectModel;
using Model.Entity;


namespace Headquarters.VM
{
    public class PlayerViewModel
    {
        public ObservableCollection<PlayerDto> Players { get; }
    }
}