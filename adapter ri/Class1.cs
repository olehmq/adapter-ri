using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adapter_ri
{
    
        public interface ITransformer
        {
            void Move();
            void Transform();
            void Draw();
            void AsphaltSpeed();
        void DirtSpeed();

        }
        

        public class AsphaltRoad
        {

            
            public void Drive(ITransformer transformer)
            {
                transformer.Move();
            }
                
            public void Show()
            {

                MessageBox.Show("car is moving on asphalt"  );
            }
        }

        public class DirtRoad
        {

            public void Drive(ITransformer transformer)
            {
                transformer.Move();

            }
            
            public void Show()
            {

                MessageBox.Show("car is moving on dirt"  );
                
            }
        }
        public class TransformerAdapter : ITransformer
        {
            private AsphaltRoad asphaltRoad;
            private DirtRoad dirtRoad;


            private bool isAsphalt;

            public TransformerAdapter()
            {
                asphaltRoad = new AsphaltRoad();
                dirtRoad = new DirtRoad();

                isAsphalt = true;
            }

            public void Draw()
            {
                throw new NotImplementedException();
            }
            public void AsphaltSpeed()
            {
            int speed = 120;
                
                    MessageBox.Show("speed is " +speed);
                
                
                
                  
                
            }
        public void DirtSpeed()
        {int speed = 50;
            MessageBox.Show("Speed is " + speed);
        }

            public void Move()
            {
                if (isAsphalt)
                {
                    asphaltRoad.Drive(this);
                }
                else
                {
                    dirtRoad.Drive(this);
                }


            }

            public void Transform()
            {
                MessageBox.Show("Changingroad");

            }
        }

    }

