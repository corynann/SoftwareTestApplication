
namespace SoftwareTestApplication.Models
{
    public class MainModel
    {
        private string _InputValues = string.Empty;
        public string InputValues { get => _InputValues; set => _InputValues = value; }

        private string _OutputValues = string.Empty;
        public string OutputValues { get => _OutputValues; set => _OutputValues = value; }

        /// <summary>
        /// Default Constructer
        /// </summary>
        public MainModel()
        {
            InputValues = "12,-10,3,4,5,8";
        }

        /// <summary>
        /// Simple Clear Function
        /// </summary>
        public void Clear()
        {
            _InputValues = string.Empty;
            _OutputValues = string.Empty;
        }
    }
}
