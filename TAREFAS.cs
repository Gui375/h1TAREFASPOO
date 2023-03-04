namespace listaTarefas
{
    public class tarefas
    {
        public string nome;
        public int esforco; // em horas
        public bool finalizado=false;

        // public tarefas(){}
        // //construtor
        // public tarefas(string Nome, int Esforco){
        //     nome = Nome;
        //     esforco = Esforco;
        // }    

        public void gerarTarefa(string Nome, int Esforco)
        {
            nome = Nome;
            esforco = Esforco;
        }

        public bool tarefafeita(bool finalizado){
            
            bool final=finalizado;
            
            
            
            return finalizado;
        }

    }
}