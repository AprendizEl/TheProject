using HelixToolkit.Wpf;
using LiveChartsCore.SkiaSharpView.Painting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.LinkLabel;

namespace TheProject.Controls
{
    /// <summary>
    /// Lógica de interacción para _3DC.xaml
    /// </summary>
    public partial class _3DC : UserControl
    {
        LinesVisual3D lines { get; } = new LinesVisual3D();

        private Point3D center = new Point3D();
        public _3DC()
        {

            InitializeComponent();





            #region

            CreateCylinders();


            // Crear el MeshBuilder para construir el terreno
            var meshBuilder = new MeshBuilder(true, true);

            // Dimensiones del terreno
            int width = 150;
            int depth = 150;

            // Crear un mapa de alturas con elevaciones suaves
            double[,] heights = GenerateHeightMap(width, depth);

            // Añadir los vértices del terreno al MeshBuilder
            for (int x = 0; x < width - 1; x++)
            {
                for (int z = 0; z < depth - 1; z++)
                {
                    // Definir las 4 esquinas de cada cuadrado en el terreno
                    Point3D p0 = new Point3D(x, heights[x, z], z);       // Esquina inferior izquierda
                    Point3D p1 = new Point3D(x + 1, heights[x + 1, z], z);   // Esquina inferior derecha
                    Point3D p2 = new Point3D(x + 1, heights[x + 1, z + 1], z + 1); // Esquina superior derecha
                    Point3D p3 = new Point3D(x, heights[x, z + 1], z + 1);   // Esquina superior izquierda

                    // Añadir los triángulos que forman cada cuadrado
                    meshBuilder.AddTriangle(p0, p1, p2);
                    meshBuilder.AddTriangle(p0, p2, p3);
                    meshBuilder.AddTriangle(p3, p2, p1);
                    meshBuilder.AddTriangle(p0, p3, p2);
                    meshBuilder.AddTriangle(p1, p2, p3);
                    meshBuilder.AddTriangle(p3, p1, p0);
                }
            }

            // Crear la malla del terreno
            var terrainMesh = new GeometryModel3D
            {
                Geometry = meshBuilder.ToMesh(),
                Material = new DiffuseMaterial(new SolidColorBrush(Colors.DarkOliveGreen)) // Color marrón para simular tierra
            };

            // Aplicar una rotación para colocar el terreno horizontalmente
            terrainMesh.Transform = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(1, 0, 0), -90));

            // Añadir la malla del terreno al Viewport3D
            var modelVisual = new ModelVisual3D { Content = terrainMesh };
            helixViewport.Children.Add(modelVisual);
        }

        // Función para generar un mapa de alturas con elevaciones suaves
        private double[,] GenerateHeightMap(int width, int depth)
        {
            var random = new Random();
            double[,] heights = new double[width, depth];

            for (int x = 0; x < width; x++)
            {
                for (int z = 0; z < depth; z++)
                {
                    // Generar alturas aleatorias suaves
                    heights[x, z] = Math.Sin(x * 0.050) * Math.Cos(z * 0.050) * 5 + random.NextDouble() * 0.5;
                }
            }

            return heights;
        }

        private void CreateCylinders()
        {
            // Material para los cilindros
            var cylinderMaterial = MaterialHelper.CreateMaterial(Colors.Gray);

            // Crear el primer cilindro
            var cylinderMesh1 = new MeshBuilder();
            cylinderMesh1.AddCylinder(new Point3D(0, 0, 0), new Point3D(0, 0, 10), 1, 16);
            var cylinderModel1 = new GeometryModel3D(cylinderMesh1.ToMesh(), cylinderMaterial);
            var cylinderVisual1 = new ModelVisual3D { Content = cylinderModel1 };
            helixViewport.Children.Add(cylinderVisual1);

            // Crear el segundo cilindro
            var cylinderMesh2 = new MeshBuilder();
            cylinderMesh2.AddCylinder(new Point3D(5, 0, 0), new Point3D(5, 0, 10), 1, 16);
            var cylinderModel2 = new GeometryModel3D(cylinderMesh2.ToMesh(), cylinderMaterial);
            var cylinderVisual2 = new ModelVisual3D { Content = cylinderModel2 };
            helixViewport.Children.Add(cylinderVisual2);

            // Crear el tercer cilindro
            var cylinderMesh3 = new MeshBuilder();
            cylinderMesh3.AddCylinder(new Point3D(-5, 0, 0), new Point3D(-5, 0, 10), 1, 16);
            var cylinderModel3 = new GeometryModel3D(cylinderMesh3.ToMesh(), cylinderMaterial);
            var cylinderVisual3 = new ModelVisual3D { Content = cylinderModel3 };
            helixViewport.Children.Add(cylinderVisual3);
        }
        private void newlines(int c)
        {
            lines.Points.Clear();
            helixViewport.Children.Clear();

            for (int i = 0; i < c; i++)
            {
                var p0 = new Point3D(0, 0, i);
                var p01 = new Point3D(0, 1, i);


                var p1 = new Point3D(1, 0, i);
                var p2 = new Point3D(0, 1, i);
                var p3 = new Point3D(1, 1, i);
                var p4 = new Point3D(1, 0, i);


                lines.Points.Add(p0); lines.Points.Add(p1);
                lines.Points.Add(p0); lines.Points.Add(p2);
                lines.Points.Add(p01); lines.Points.Add(p3);
                lines.Points.Add(p3); lines.Points.Add(p4);
            }

            lines.Color = Colors.White;
            helixViewport.Children.Add(lines);



        }

        private void newcircle(int baja, int rota)
        {
            // Crear el objeto LinesVisual3D
            LinesVisual3D lines = new LinesVisual3D
            {
                Color = Colors.Red, // Color de las líneas
                Thickness = 2,      // Grosor de las líneas
            };

            var s = baja;
            var m = rota;

            // Definir los puntos para las líneas
            var points = new[]
            {
            new Point3D(-2 * m, 4 * m, s), new Point3D( 2  * m, 4 * m, s),
            new Point3D(-2 * m, 4 * m, s), new Point3D(-4  * m, 3 * m, s),
            new Point3D(-4 * m, 3 * m, s), new Point3D(-5  * m, 1 * m, s),
            new Point3D(-5 * m, 1 * m, s), new Point3D(-5  * m,-3 * m, s),
            new Point3D(-5 * m,-3 * m, s), new Point3D(-4  * m,-5 * m, s),
            new Point3D(-4 * m,-5 * m, s), new Point3D(-2  * m,-6 * m, s),
            new Point3D(-2 * m,-6 * m, s), new Point3D( 2  * m,-6 * m, s),
            new Point3D( 2 * m,-6 * m, s), new Point3D( 4  * m,-5 * m, s),
            new Point3D( 4 * m,-5 * m, s), new Point3D( 5  * m,-3 * m, s),
            new Point3D( 5 * m,-3 * m, s), new Point3D( 5  * m, 1 * m, s),
            new Point3D( 5 * m, 1 * m, s), new Point3D( 4  * m, 3 * m, s),
            new Point3D( 4 * m, 3 * m, s), new Point3D( 2  * m, 4 * m, s)
        };

            // Asignar los puntos al LinesVisual3D
            for (int i = 0; i < points.Length; i++)
            {
                lines.Points.Add(points[i]);
            }


            // Añadir el LinesVisual3D al Viewport3D
            helixViewport.Children.Add(lines);
        }

        private Point3D GetPosition(double r,double y, double theta)
        {
            double x = r * Math.Cos(theta);
            double z = -r * Math.Sin(theta);
            return new Point3D(x, y, z);
        }

        private void newcylider()
        {
            LinesVisual3D lines = new LinesVisual3D
            {
                Color = Colors.Blue, // Puedes cambiar el color según tu preferencia
                Thickness = 2
            };


            //// Agregar los puntos y líneas correspondientes
            //lines.Points.Add(new Point3D(-2, 4, -2));
            //lines.Points.Add(new Point3D(-4, 3, -5));

            //lines.Points.Add(new Point3D(-4, 3, -5));
            //lines.Points.Add(new Point3D(-5, 1, -8));

            //lines.Points.Add(new Point3D(-5, 1, -8));
            //lines.Points.Add(new Point3D(-5, -5, -9));

            //lines.Points.Add(new Point3D(-5, -5, -9));
            //lines.Points.Add(new Point3D(-4, -7, -10));

            //lines.Points.Add(new Point3D(-4, -7, -10));
            //lines.Points.Add(new Point3D(-2, -8, -14));

            //lines.Points.Add(new Point3D(-2, -8, -14));
            //lines.Points.Add(new Point3D(2, -8, -14));

            //lines.Points.Add(new Point3D(2, -8, -14));
            //lines.Points.Add(new Point3D(4, -7, -10));

            //lines.Points.Add(new Point3D(4, -7, -10));
            //lines.Points.Add(new Point3D(5, -5, -9));

            //lines.Points.Add(new Point3D(5, -5, -9));
            //lines.Points.Add(new Point3D(5, 1, -8));

            //lines.Points.Add(new Point3D(5, 1, -8));
            //lines.Points.Add(new Point3D(4, 3, -5));

            //lines.Points.Add(new Point3D(4, 3, -5));
            //lines.Points.Add(new Point3D(2, 4, -2));

            //lines.Points.Add(new Point3D(2, 4, -2));
            //lines.Points.Add(new Point3D(-2, 4, -2));

            for (int i = 0; i < 48; i++)
            {
                double angle = i * Math.PI / 24;
                lines.Points.Add(new Point3D(
                0 + 6 * Math.Cos(angle), 6 * Math.Sin(angle), 2
               ));
            }









            // Añadir al viewport 3D
            helixViewport.Children.Add(lines);



        }

        private void newhiporbele()
        {
            LinesVisual3D lines = new LinesVisual3D
            {
                Color = Colors.Green, // Puedes cambiar el color según prefieras
                Thickness = 2
            };

            // Agregar los puntos y líneas correspondientes
            lines.Points.Add(new Point3D(-2, 4, -5));
            lines.Points.Add(new Point3D(2, 4, -5));

            lines.Points.Add(new Point3D(-2, 4, -5));
            lines.Points.Add(new Point3D(-4, 3, -7));

            lines.Points.Add(new Point3D(-4, 3, -7));
            lines.Points.Add(new Point3D(-5, 1, -10));

            lines.Points.Add(new Point3D(-5, 1, -10));
            lines.Points.Add(new Point3D(-5, -5, -20));

            // Línea final del otro lado
            lines.Points.Add(new Point3D(5, -5, -20));
            lines.Points.Add(new Point3D(5, 1, -10));

            lines.Points.Add(new Point3D(5, 1, -10));
            lines.Points.Add(new Point3D(4, 3, -7));

            lines.Points.Add(new Point3D(4, 3, -7));
            lines.Points.Add(new Point3D(2, 4, -5));

            // Añadir al viewport 3D
            helixViewport.Children.Add(lines);


        }


        public void CreateRotatedFigures(HelixViewport3D viewport)
        {
            LinesVisual3D lines = new LinesVisual3D
            {
                Color = Colors.Blue,
                Thickness = 2
            };

            List<Point3D> originalPoints = new List<Point3D>
                {



                    new Point3D(0,1, 12),
                    new Point3D(0, 2, 11.5),
                    new Point3D(0, 3, 11),
                    new Point3D(0, 4, 10),
                    new Point3D(0, 4.5,9),
                    new Point3D(0, 5, 8),
                    new Point3D(0, 6, 7),
                    new Point3D(0, 7, 6),
                    new Point3D(0, 7.5, 5),
                    new Point3D(0, 6, 3),
                    new Point3D(0, 3, 1),
                    new Point3D(0, 2, 0),
                    new Point3D(0, 1, -0.5) // Cierre de la figura



                };

            // Ángulo de rotación en radianes
            double angleStep = Math.PI / 6; // rotación en pasos de 30 grados

            for (int i = 0; i < 20; i++) // Crear 12 figuras rotadas
            {


                // Añadir los puntos originales


                // Calcular ángulo de rotación actual
                double theta = i * angleStep;

                // Aplicar rotación a cada punto y añadir líneas
                for (int j = 0; j < originalPoints.Count - 1; j++)
                {
                    Point3D p1 = RotatePointZ(originalPoints[j], theta);

                    Point3D p2 = RotatePointZ(originalPoints[j + 1], theta);


                    lines.Points.Add(p1);
                    lines.Points.Add(p2);
                }

                // Añadir las líneas al Viewport

            }

            for (int i = 0; i < originalPoints.Count; i++)
            {
                var punto = originalPoints[i];

                for (int c = 0; c < 15; c++)
                {
                    double angle = c * Math.PI / 8;
                    lines.Points.Add(new Point3D(
                    0 + punto.Y * Math.Cos(angle), punto.Y * Math.Sin(angle), punto.Z
                   ));
                }



            }

            var s = originalPoints.Max(x => x.Z);
            var s1 = originalPoints.Min(x => x.Z);

            lines.Points.Add(new Point3D(0,0,s));
            lines.Points.Add(new Point3D(0, 0, s1));

            viewport.Children.Add(lines);

        }

        // Función para rotar un punto alrededor del eje Z
        public Point3D RotatePointZ(Point3D point, double theta)
        {
            double cosTheta = Math.Cos(theta);
            double sinTheta = Math.Sin(theta);

            double x = point.X * cosTheta - point.Y * sinTheta;
            double y = point.X * sinTheta + point.Y * cosTheta;
            double z = point.Z;

            return new Point3D(x, y, z);
        }


        public void create()
        {
            newcircle(1, 1);
            newcylider();
            newhiporbele();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var sphere = new SphereVisual3D()
            {
                Fill = new SolidColorBrush(Color.FromRgb(200, 200, 200)),
                Center = new Point3D(0, 0, 0),
                Radius = 2
            };



            int num = int.Parse(Se.Text);
            newlines(num);
            //newcylider();
            helixViewport.UpdateLayout();
            CreateRotatedFigures(helixViewport);
            helixViewport.Children.Add(sphere);


        }
        #endregion


    }
}
