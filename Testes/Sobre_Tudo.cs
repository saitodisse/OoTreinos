using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using KoansCSharpPtBr.helpers;
using NUnit.Framework;

namespace KoansCSharpPtBr
{
    [TestFixture]
    public class Sobre_Tudo
    {
        /*
        
        Sobre Assert do unit

         * * 
         * Para rodar todos os teste use Ctrl + U, L
         * Para rodar apenas o teste atual use Ctrl + U, R
         * Para rodar apenas o teste atual com debug use Ctrl + U, D
         * *
        */
        [Test]
        public void __001_o_que_e_esperado_no_assert_true()
        {
            Assert.True(___, "001	O que é esperado no Assert_True?");
        }

        [Test]
        public void __002_o_que_faz_este_assert_are_equal_passar()
        {
            Assert.AreEqual(___, 1 + 1 + 1, "002	O que faz este Assert.Are_Equal passar?");
        }

        /*
        
        Sobre a matemática
        
        */
        [Test]
        public void __003_quanto_e_a_soma_de_1_1()
        {
            Assert.AreEqual(___, 1+1, "003	Quanto é a soma de 1 + 1?");
        }

        [Test]
        public void __004_quanto_da_a_multiplicacao()
        {
            Assert.AreEqual(___, 2*6, "004	Quanto da a multiplicação?");
        }

        [Test]
        public void __005_na_divisao_com_inteiros_qual_e_o_resultado()
        {
            /*
             * Apesar do resultado não ser inteiro, dá inteiro
             * isto porque 1 é inteiro e 1.0 é double
             */
            Assert.AreEqual(___, 5/2, "005	Na divisão com inteiros qual é o resultado?");
        }

        [Test]
        public void __006_o_modulo_sempre_retorna_o_resto_da_divisao()
        {
            Assert.AreEqual(___, 5%2, "006	O modulo sempre retorna o resto da divisão");
        }

        /*
        
        Sobre os operadores
        
        */
        [Test]
        public void __007_qual_o_valor_de_x()
        {
            int num = 1;
            Assert.AreEqual(___, num, "007	Qual o valor de x?");
        }

        [Test]
        public void __008_qual_o_valor_de_x_apos_usar_o_operador_mais_mais()
        {
            int num = 1;
            num++;
            Assert.AreEqual(___, num, "008	Qual o valor de x apos usar o operador mais mais?");
        }

        [Test]
        public void __009_qual_o_valor_de_x_apos_usar_o_operador_mais_igual()
        {
            int num = 1;
            num += 2;
            Assert.AreEqual(___, num, "009	Qual o valor de x apos usar o operador mais igual");
        }

        [Test]
        public void __010_e_como_que_fica_quando_o_mais_mais_e_colocado_antes()
        {
            int num = 1;
            Assert.AreEqual(___, ++num, "010.1	E como que fica quando o mais mais é colocado antes?");
            Assert.AreEqual(___, num++, "010.2	mas é a mesma coisa que depois?");
            Assert.AreEqual(___, num, "010.3	e agora, quanto vale o num?");
        }

        /*
        
        Sobre as igualdades
        
        */
        [Test]
        public void __011_os_numeros_sao_iguais()
        {
            Assert.AreEqual(___, 4==4, "011	Os numeros são iguais?");
        }

        [Test]
        public void __012_e_essas_strings()
        {
            Assert.AreEqual(____, "abc" == "abd", "012	E essas strings?");
        }

        [Test]
        public void __013_o_numero_inteiro_e_igual_ao_seu_amigo_double()
        {
            Assert.AreEqual(___, 2.0 == 2, "013	O número inteiro é igual ao seu amigo double?");
        }

        [Test]
        public void __014_como_que_fica_na_comparacao_de_strings_com_numeros()
        {
            Assert.AreEqual(____, 2.Equals("2"), "014	Como que fica na comparação de strings com numeros");
        }

        [Test]
        public void __015_e_se_a_gente_resolve_converter_com_o_parse()
        {
            Assert.AreEqual(___, int.Parse("2"), "015	E se a gente resolve converter com o parse?");
        }

        [Test]
        public void __016_e_se_a_gente_resolve_converter_com_o_convert_to_algo()
        {
            Assert.AreEqual(___, Convert.ToInt32("887"), "016	E se a gente resolve converter com o Convert_to_algo?");
        }

        [Test]
        public void __017_o_cast_permite_transformar_um_tipo_em_outro_quando_possivel()
        {
            Assert.AreEqual(___, (int)2.4, "017	O cast permite transformar um tipo em outro, quando possivel");
        }

        /*
        
        Sobre as estruturas de controle
        
        */
        [Test]
        public void __018_if_alguma_coisa_senao_outra()
        {
            var letra = "a";
            var resultado = "";
            if (letra == "b")
            {
                resultado = "é b";
            }
            else
            {
                resultado = "não é b";
            }
            Assert.AreEqual(___, resultado, "018	If alguma coisa senao outra");
        }

        [Test]
        public void __019_qual_o_valor_de_x_apos_aplicar_o_operador_ternario()
        {
            var letra = "Z";
            string resultado = letra == "Z" ? "é Z" : "não é Z";

            Assert.AreEqual(___, resultado, "019	Qual o valor de x após aplicar o operador ternário?");
        }

        [Test]
        public void __020_switch_case_alguma_coisa()
        {
            var letra = "c";
            var resultado = "";

            switch (letra)
            {
                case "a":
                    resultado = "é a";
                    break;
                case "b":
                    resultado = "é b";
                    break;
                case "c":
                    resultado = "é c";
                    break;
            }

            Assert.AreEqual(___, resultado, "020	Switch case alguma coisa");
        }

        [Test]
        public void __021_switch_case_alguma_coisa_com_default()
        {
            var letra = "d";
            var resultado = "";

            switch (letra)
            {
                case "a":
                    resultado = "é a";
                    break;
                case "b":
                    resultado = "é b";
                    break;
                case "c":
                    resultado = "é c";
                    break;
                default:
                    resultado = "nda";
                    break;
            }

            Assert.AreEqual(___, resultado, "021	Switch case alguma coisa com default");
        }

        [Test]
        public void __022_qual_o_valor_de_x_apos_esse_for()
        {
            var x = 0;
            for (int i = 0; i < 5; i++)
            {
                x += i;
            }
            Assert.AreEqual(___, x, "022	Qual o valor de x após esse for?");
        }

        [Test]
        public void __023_qual_o_valor_de_x_apos_esse_while()
        {
            var x = 0;
            int i = 0;
            while(i < 4)
            {
                x += i;
                i++;
            }
            Assert.AreEqual(___, x, "023	Qual o valor de x após esse while?");
        }

        [Test]
        public void __024_o_foreach_itera_sobre_um_array_list_de_objetos()
        {
            ArrayList array = new ArrayList();
            /*
             * um array list pode guardar qualquer object
             * neste caso está guardando inteiros
             */
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);

            var resultado = 0;
            foreach (var item in array)
            {
                /*
                 * temos que usar o cast para converter o objeto para int
                 */
                var numero = (int)item;
                resultado += numero;
            }

            Assert.AreEqual(___, resultado, "024	O foreach itera sobre um ArrayList de objetos");
        }

        [Test]
        public void __025_o_foreach_itera_sobre_uma_lista_tipada()
        {
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            var resultado = 0;
            foreach (var item in lista)
            {
                /*
                 * observe que aqui não é necessário usar o cast "(int)"
                 */
                var numero = item;
                resultado += numero;
            }


            Assert.AreEqual(___, resultado, "025	O foreach itera sobre uma lista tipada");
        }

        [Test]
        public void __026_o_break_interrompe_um_fluxo()
        {
            var x = 0;
            for (int i = 0; i < 5; i++)
            {
                x += i;
                if (x > 3)
                {
                    break;
                }
            }
            Assert.AreEqual(___, x, "026	O break interrompe um fluxo. Quanto vale o x então?");
        }

        /*
        
        Sobre as strings
        
        */
        [Test]
        public void __027_da_pra_juntar_string_com_o_mais()
        {
            string fraseA = "eu sou";
            string fraseB = "um programador";
            string juncaoFrases = fraseA + " " + fraseB;

            Assert.AreEqual(___, juncaoFrases, "027	Dá pra juntar string com o mais");
        }

        [Test]
        public void __028_mas_tambem_da_com_o_string_concat()
        {
            string fraseA = "eu sou";
            string fraseB = "mais um programador";
            string juncaoFrases = string.Concat(fraseA, " ", fraseB);

            Assert.AreEqual(___, juncaoFrases, "028	Mas também dá com o string.concat(a,b)");
        }

        [Test]
        public void __029_o_string_format_a_tambem_faz_strings_bonitas()
        {
            string frase = string.Format("O número é {0}. {0} é maior que {1}.", 3, 2);
            Assert.AreEqual(___, frase, "029	O string.format(\"{0}\", a) também faz strings bonitas");
        }

        [Test]
        public void __030_se_for_fazer_muita_concatenacao_e_bom_usar_o_new_stringbuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("E");
            sb.Append("u");
            sb.Append(" ");
            sb.Append("s");
            sb.Append("o");
            sb.Append("u");
            sb.Append(" ");
            sb.Append("e");
            sb.Append("u");
            sb.Append(".");

            /*
             é preciso usar o .ToString() pra juntar tudo no final
             */
            string resultado = sb.ToString();

            Assert.AreEqual(___, resultado, "030	Se for fazer muita concatenação é bom usar o new StringBuilder()");
        }

        [Test]
        public void __031_com_o_string_length_da_pra_saber_o_tamanho_da_string()
        {
            int tamanho = "qual meu tamanho?".Length;
            Assert.AreEqual(___, tamanho, "031	Com o string.Length dá pra saber o tamanho da string");
        }

        [Test]
        public void __032_o_split_permite_transformar_a_string_num_array()
        {
            string frase = "cada palavra vai ficar num item do array";
            string[] strings = frase.Split(' ');
            Assert.AreEqual(___, strings[2], "032	O .Split() permite transformar a string num array");
        }

        /*
        
        Sobre os objetos
        
        */

        public class Mamifero
        {
            public Mamifero(string nome)
            {
                this.Nome = nome;
            }
            private string variavelPrivada = "eu não sou visivel de fora";

            public string variavelPublica = "todo mundo pode me ver";

            /*
             As propriedades mantém o estado do objeto.
             Neste caso este objeto tem um Nome.
             O "Nome" está declarado no formato "auto-property"
             */
            public string Nome { get; set; }

            /*
             Esta outra propriedade está sendo utilizada no modo clássico
             Nesta forma você tem um field (variável) privado
             e dois métodos. Um para obter o valor (get) e outro para atribuir (set)
             */
            private string _propriedadeMudaGet;
            public string PropriedadeMudaGet
            {
                get { return "get:" + _propriedadeMudaGet; }
                set { _propriedadeMudaGet = value; }
            }

            private int estoqueLeite = 100;
            /*
             As operações são métodos que podem alterar o estado interno do objeto.
             O Amamentar() debita o estoqueLeite;
             Se o leite acaber, dispara um erro.
             */
            public void Amamentar()
            {
                estoqueLeite -= 30;

                if(estoqueLeite <= 0)
                {
                    throw new Exception("O leite acabou!");
                }
            }
        }

        [Test]
        public void __033_o_new_instancia_uma_classe()
        {
            Mamifero gato = new Mamifero("Gatinho");
            Assert.AreEqual(____, gato == null, "033	O new instancia uma classe");
        }

        [Test]
        public void __034_a_classe_sempre_executa_seu_construtor_quando_criada_com_o_new()
        {
            Mamifero gato = new Mamifero("Gatinho");
            Assert.AreEqual(___, gato.Nome, "034	A classe sempre executa seu construtor quando criada com o new");
        }

        [Test]
        public void __035_variaveis_privadas_da_classe_nao_sao_visiveis_de_fora_dela()
        {
            Mamifero gato = new Mamifero("Gatinho");

            /*
             não se pode acessar a variavelPrivada
             o máximo que podemos fazer é acessar via reflection.
             mas isso é um processo conhecido como gambiarra.
             */


            Assert.AreEqual(___, gato.GetType().GetField("variavelPrivada").IsPrivate, "035	Variáveis privadas da classe não são visiveis de fora dela");
        }

        [Test]
        public void __036_variaveis_publicas_da_classe_sao_visiveis_de_fora_dela()
        {
            Mamifero gato = new Mamifero("Gatinho");
            gato.variavelPublica = "123";
            Assert.AreEqual(___, gato.variavelPublica, "036	Variáveis públicas da classe são visiveis de fora dela");
        }

        [Test]
        public void __037_mas_e_aconselhavel_se_usar_propriedades()
        {
            Mamifero gato = new Mamifero("Gatinho");
            gato.Nome = "Cachorro";
            Assert.AreEqual(___, gato.Nome, "037	Mas é aconselhável se usar propriedades");
        }

        [Test]
        public void __038_dessa_forma_se_pode_controlar_o_get_e_set_separadamente()
        {
            Mamifero gato = new Mamifero("Gatinho");
            gato.PropriedadeMudaGet = "texto";

            /*
             veja a propriedade para entender porque não veio "texto"
             */
            Assert.AreEqual(___, gato.PropriedadeMudaGet, "038	Dessa forma se pode controlar o get e set separadamente");
        }

        [Test]
        public void __039_classes_tambem_possuem_comportamentos_os_metodos()
        {
            Mamifero gato = new Mamifero("Gatinho");
            gato.Amamentar();
            gato.Amamentar();
            gato.Amamentar();

            /*
             repare que quando o estoque de leite acaba
             o Mamifero dispara uma excessão
             */
            Assert.Throws<Exception>(gato.Amamentar, "039	Classes também possuem comportamentos, os métodos");
        }



        protected bool ___
        {
            get { return false; }
            set { throw new System.NotImplementedException(); }
        }
        protected object ____
        {
            get { return ""; }
            set { throw new System.NotImplementedException(); }
        }
    }
}

/*
 * 
 * Usar esse template com o https://github.com/saitodisse/EmeTools
 
	# 00000000000000000000000  Sobre Assert do unit
001	O que é esperado no Assert_True?
002	O que faz este Assert.Are_Equal passar?
	# 00000000000000000000000  Sobre a matematica
003	Quanto é a soma de 1 + 1?
004	Quanto da a multiplicação?
005	Na divisão com inteiros qual é o resultado?
006	O modulo sempre retorna o resto da divisão
	# 00000000000000000000000  Sobre os operadores
007	Qual o valor de x?
008	Qual o valor de x apos usar o operador mais mais?
009	Qual o valor de x apos usar o operador mais igual
010	E como que fica quando o mais mais é colocado antes?
	# 00000000000000000000000  Sobre as igualdades
011	Os numeros são iguais?
012	E essas strings?
013	O número inteiro é igual ao seu amigo double?
014	Como que fica na comparação de strings com numeros
015	E se a gente resolve converter com o parse?
016	E se a gente resolve converter com o Convert_to_algo?
017	O cast permite transformar um tipo em outro, quando possivel
	# 00000000000000000000000  Sobre as estruturas de controle
018	If alguma coisa senao outra
019	Qual o valor de x após aplicar o operador ternário?
020	Switch case alguma coisa
021	Switch case alguma coisa com default
022	Qual o valor de x após esse for?
023	Qual o valor de x após esse while?
024	O foreach itera sobre um array
025	O foreach itera sobre uma lista
026	O break interrompe um fluxo
	# 00000000000000000000000  Sobre as strings
027	Dá pra juntar string com o mais
028	Mas também dá com o string.concat(a,b)
029	O string.format("", a) também faz strings bonitas
030	Se for fazer muita concatenação é bom usar o new StringBuilder()
031	Com o string.Length dá pra saber o tamanho da string
032	O .Split() permite transformar a string num array
	# 00000000000000000000000  Sobre os objetos
033	O new instancia uma classe
034	A classe sempre executa seu construtor quando criada com o new
035	Variáveis privadas da classe não são visiveis de fora dela
036	Variáveis públicas da classe são visiveis de fora dela
037	Mas é aconselhável se usar propriedades
038	Dessa forma se pode controlar o get e set separadamente
039	Classes também possuem comportamentos, os métodos
///r
[\t \.-]
/
_
///r
[\\;,\/?!@#$%¨&*\(\)´`'"\+\-\=]
/

///r
_+
/
_
///c
#[[variavel]]
toLower
firstToUpper
retirarAcentos
///x
[Test]
public void __xxx3()
{
  Assert.AreEqual(___, yyy, "xxx-1");
}

 * 
 */
