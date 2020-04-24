using System.ComponentModel;
using System.Windows;
using com.variflight.dataservice.client;
using Com.Variflight.Fidstest.Flight;
using Google.Protobuf.WellKnownTypes;

namespace test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Grpc.Core.Channel channel = new Grpc.Core.Channel("192.168.203.244:8081", Grpc.Core.ChannelCredentials.Insecure);
        //private Com.Variflight.Dataservice.Test.ScoreService.ScoreServiceClient client = null;
        private FlightService.FlightServiceClient client = null;
        public event PropertyChangedEventHandler PropertyChanged;

        private Com.Variflight.Fidstest.Flight.dao.FlightList _data;
        public Com.Variflight.Fidstest.Flight.dao.FlightList Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Data"));
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            client = new FlightService.FlightServiceClient(channel);
            this.DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            client.LoopCall(client.PullFlightInfoAsync, new Nothing(), (Com.Variflight.Fidstest.Flight.dao.FlightList data) =>
            {
                this.Data = data;
            });
        }
    }
}
