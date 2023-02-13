using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ProjetoB")]
namespace ProjetoA
{
    #region Classes

    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    //Só pode ser instanciada
    public sealed class Selada { }

    //Classe privada, não é necessário colocar o modificador de acesso private
    class Privada { }

    internal class Interna { }

    // não pode ser instanciado, somente herdado
    abstract class Abstrata { }

    #endregion
    
    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    //class TesteSelada : Selada { }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
            //TestePrivado();
        }
    }

    #endregion
}

/*******************************************************/
// public:

// Access is not restricted.
/*******************************************************/
// protected:

// Access is limited to the containing class or types
// derived from the containing class.
/*******************************************************/
// internal:

// Access is limited to the current assembly(DLL)
/*******************************************************/
// protected internal:

// Access is limited to the current assembly or types
// derived from the containing class.
/*******************************************************/
// private:

// Access is limited to the containing type.
/*******************************************************/
// private protected:

// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly.Available since C# 7.2.
/*******************************************************/
