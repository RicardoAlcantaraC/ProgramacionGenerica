using System;

namespace ProgramacionGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de la clase generica de tipo Empleado
            AlmacenObjetos<Empleado> miAlmacen = new AlmacenObjetos<Empleado>(4);
            
            //Agrego elementos de tipo empleado
            miAlmacen.agregar(new Empleado(1000));
            miAlmacen.agregar(new Empleado(9000));
            miAlmacen.agregar(new Empleado(3000));
            miAlmacen.agregar(new Empleado(4000));
           

            //instancia de la clase empleado igualado a un elemento del almacen de tipo Empleado
            Empleado salarioEmpleado = miAlmacen.getElemento(2);
            Console.WriteLine(salarioEmpleado.getSalario());


            //Almacen de tipo String
            AlmacenObjetos<String> miAlmacenNombres = new AlmacenObjetos<String>(4);

            miAlmacenNombres.agregar("Ricardo");
            miAlmacenNombres.agregar("Itzel");
            miAlmacenNombres.agregar("Emiliano");
            miAlmacenNombres.agregar("Adriana");

            String persona = miAlmacenNombres.getElemento(1);
            Console.WriteLine(persona);
        }
    }

    class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];
        }

        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }
        
        private T[] datosElemento;
        private int i=0;
    }

    class Empleado
    {
        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return salario;
        }

        private double salario;
    }


}
