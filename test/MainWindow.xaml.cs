using System.ComponentModel;
using System.Windows;
using com.variflight.dataservice.client;
using Google.Protobuf.WellKnownTypes;

namespace test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Grpc.Core.Channel channel = new Grpc.Core.Channel("10.9.9.131:11180", Grpc.Core.ChannelCredentials.Insecure);
        private Com.Variflight.Dataservice.Test.ScoreService.ScoreServiceClient client = null;

        public event PropertyChangedEventHandler PropertyChanged;

        private Com.Variflight.Dataservice.Test.dao.StudentScoresMap _data;
        public Com.Variflight.Dataservice.Test.dao.StudentScoresMap Data { 
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
            client = new Com.Variflight.Dataservice.Test.ScoreService.ScoreServiceClient(channel);
            this.DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            client.LoopCall(client.GetAllScoresAsync, new Empty(), (Com.Variflight.Dataservice.Test.dao.StudentScoresMap data) => {
                this.Data = data;
            });
        }
    }
}
