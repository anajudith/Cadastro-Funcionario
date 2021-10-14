using System;

class Funcionário
    {
        private string _Matrícula;

        public string Matrícula
        {
            get { return _Matrícula; }
            set { _Matrícula = value; }
        }

        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Depto;

        public string Depto
        {
            get { return _Depto; }
            set { _Depto = value; }
        }

        private double _Salário;

        public double Salário
        {
            get { return _Salário; }
            set
            {
                if (value < 0)
                    _Salário = 0;
            }
        }

        private Data _Admissão;

        public Data Admissão
        {
            get { return _Admissão; }
            set { _Admissão = value; }
        }

        public void LerDados()
        {
            Console.Write("Matrícula do Funcionário: ");
            _Matrícula = Console.ReadLine();

            Console.Write("Nome do Funcionário.....: ");
            _Nome = Console.ReadLine();

            Console.Write("Departamento............: ");
            _Depto = Console.ReadLine();

            Console.Write("Salário (R$)............: ");
            _Salário = double.Parse(Console.ReadLine());

            _Admissão = new Data();

            Console.Write("Data de Admissão - Dia..: ");
            _Admissão.Dia = int.Parse(Console.ReadLine());

            Console.Write("                   Mês..: ");
            _Admissão.Mês = Console.ReadLine();

            Console.Write("                   Ano..: ");
            _Admissão.Ano = int.Parse(Console.ReadLine());
        }
    }