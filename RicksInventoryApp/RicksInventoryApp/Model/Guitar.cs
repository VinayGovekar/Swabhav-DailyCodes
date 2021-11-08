using RicksInventoryApp.Model.Enums;
namespace RicksInventoryApp.Model
{
    public class Guitar : Instrument
    {
        private Builder _builder;
        private string _model;
        private GType _type;
        private Wood _backWood;
        private Wood _topWood;
        private int _numberOfStrings;
        public Guitar(string serialNum,double price,Builder builder,string model, GType type, Wood backWood, Wood topWood,int numStrings)
        {
            _serialNumber = serialNum;
            _price = price;
            _builder = builder;
            _model = model;
            _type = type;
            _backWood = backWood;
            _topWood = topWood;
            _numberOfStrings = numStrings;
        }
        public Guitar(Builder builder, string model, GType type, Wood backWood, Wood topWood, int numStrings):
            this("",0,builder,model,type,backWood,topWood,numStrings)
        {
        }

        public Builder Builder
        {
            get { return _builder; }
        }
        public string Model
        {
            get { return _model; }
        }
        public GType GuitarType
        {
            get { return _type; }
        }
        public Wood BackWood
        {
            get { return _backWood; }
        }
        public Wood TopWood
        {
            get { return _topWood; }
        }
        public int NumberOfStrings
        {
            get { return _numberOfStrings; }
        }
        public override bool Equals(object obj)
        {
            Guitar guitarObj = (Guitar)obj;
            if (this.Builder==guitarObj.Builder && this.Model.ToLower()==guitarObj.Model.ToLower() && this.GuitarType == guitarObj.GuitarType &&
                this.BackWood == guitarObj.BackWood && this.TopWood == guitarObj.TopWood && 
                this.NumberOfStrings==guitarObj.NumberOfStrings) return true;
            return false; 
        }
    }
}
