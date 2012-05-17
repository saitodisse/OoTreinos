using KoansCSharpPtBr.helpers;
using NUnit.Framework;

namespace KoansCSharpPtBr
{
    [TestFixture]
    public class _01_Sobre_Asserts_Do_NUnit : _ZZ_TestePai
    {
        /*
        
        Sobre Assert do unit
        
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
            Assert.AreEqual(___, "abc" == "abd", "012	E essas strings?");
        }

        [Test]
        public void __013_o_numero_inteiro_e_igual_ao_seu_amigo_double()
        {
            Assert.AreEqual(___, 2.0 == 2, "013	O número inteiro é igual ao seu amigo double?");
        }

        [Test]
        public void __014_como_que_fica_na_comparacao_de_strings_com_numeros()
        {
            Assert.AreEqual(___, 2.Equals("2"), "014	Como que fica na comparação de strings com numeros");
        }

        [Test]
        public void __015_e_se_a_gente_resolve_converter_com_o_parse()
        {
            Assert.AreEqual(___, yyy, "015	E se a gente resolve converter com o parse?");
        }

        [Test]
        public void __016_e_se_a_gente_resolve_converter_com_o_convert_to_algo()
        {
            Assert.AreEqual(___, yyy, "016	E se a gente resolve converter com o Convert_to_algo?");
        }

        [Test]
        public void __017_o_cast_permite_transformar_um_tipo_em_outro_quando_possivel()
        {
            Assert.AreEqual(___, yyy, "017	O cast permite transformar um tipo em outro, quando possivel");
        }

        /*
        
        Sobre as estruturas de controle
        
        */
        [Test]
        public void __018_if_alguma_coisa_senao_outra()
        {
            Assert.AreEqual(___, yyy, "018	If alguma coisa senao outra");
        }

        [Test]
        public void __019_qual_o_valor_de_x_apos_aplicar_o_operador_ternario()
        {
            Assert.AreEqual(___, yyy, "019	Qual o valor de x após aplicar o operador ternário?");
        }

        [Test]
        public void __020_switch_case_alguma_coisa()
        {
            Assert.AreEqual(___, yyy, "020	Switch case alguma coisa");
        }

        [Test]
        public void __021_switch_case_alguma_coisa_com_default()
        {
            Assert.AreEqual(___, yyy, "021	Switch case alguma coisa com default");
        }

        [Test]
        public void __022_qual_o_valor_de_x_apos_esse_for()
        {
            Assert.AreEqual(___, yyy, "022	Qual o valor de x após esse for?");
        }

        [Test]
        public void __023_qual_o_valor_de_x_apos_esse_while()
        {
            Assert.AreEqual(___, yyy, "023	Qual o valor de x após esse while?");
        }

        [Test]
        public void __024_o_foreach_itera_sobre_um_array()
        {
            Assert.AreEqual(___, yyy, "024	O foreach itera sobre um array");
        }

        [Test]
        public void __025_o_foreach_itera_sobre_uma_lista()
        {
            Assert.AreEqual(___, yyy, "025	O foreach itera sobre uma lista");
        }

        [Test]
        public void __026_o_break_interrompe_um_fluxo()
        {
            Assert.AreEqual(___, yyy, "026	O break interrompe um fluxo");
        }

        /*
        
        Sobre as strings
        
        */
        [Test]
        public void __027_da_pra_juntar_string_com_o_mais()
        {
            Assert.AreEqual(___, yyy, "027	Dá pra juntar string com o mais");
        }

        [Test]
        public void __028_mas_tambem_da_com_o_string_concatab()
        {
            Assert.AreEqual(___, yyy, "028	Mas também dá com o string.concat(a,b)");
        }

        [Test]
        public void __029_o_string_format_a_tambem_faz_strings_bonitas()
{
  Assert.AreEqual(___, yyy, "029	O string.format("", a) também faz strings bonitas");
}

        [Test]
        public void __030_se_for_fazer_muita_concatenacao_e_bom_usar_o_new_stringbuilder()
        {
            Assert.AreEqual(___, yyy, "030	Se for fazer muita concatenação é bom usar o new StringBuilder()");
        }

        [Test]
        public void __031_com_o_string_length_da_pra_saber_o_tamanho_da_string()
        {
            Assert.AreEqual(___, yyy, "031	Com o string.Length dá pra saber o tamanho da string");
        }

        [Test]
        public void __032_o_split_permite_transformar_a_string_num_array()
        {
            Assert.AreEqual(___, yyy, "032	O .Split() permite transformar a string num array");
        }

        /*
        
        Sobre os objetos
        
        */
        [Test]
        public void __033_o_new_instancia_uma_classe()
        {
            Assert.AreEqual(___, yyy, "033	O new instancia uma classe");
        }

        [Test]
        public void __034_a_classe_sempre_executa_seu_construtor_quando_criada_com_o_new()
        {
            Assert.AreEqual(___, yyy, "034	A classe sempre executa seu construtor quando criada com o new");
        }

        [Test]
        public void __035_variaveis_privadas_da_classe_nao_sao_visiveis_de_fora_dela()
        {
            Assert.AreEqual(___, yyy, "035	Variáveis privadas da classe não são visiveis de fora dela");
        }

        [Test]
        public void __036_variaveis_publicas_da_classe_sao_visiveis_de_fora_dela()
        {
            Assert.AreEqual(___, yyy, "036	Variáveis públicas da classe são visiveis de fora dela");
        }

        [Test]
        public void __037_mas_e_aconselhavel_se_usar_propriedades()
        {
            Assert.AreEqual(___, yyy, "037	Mas é aconselhável se usar propriedades");
        }

        [Test]
        public void __038_dessa_forma_se_pode_controlar_o_get_e_set_separadamente()
        {
            Assert.AreEqual(___, yyy, "038	Dessa forma se pode controlar o get e set separadamente");
        }

        [Test]
        public void __039_classes_tambem_possuem_comportamentos_os_metodos()
        {
            Assert.AreEqual(___, yyy, "039	Classes também possuem comportamentos, os métodos");
        }

        [Test]
        public void __040_os_metodos_podem_alterar_o_estado_da_classe()
        {
            Assert.AreEqual(___, yyy, "040	Os métodos podem alterar o estado da classe");
        }
    }
}
