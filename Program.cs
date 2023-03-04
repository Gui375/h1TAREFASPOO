using listaTarefas;

List<tarefas> l = new List<tarefas>();
char e = 's';
int menu;
Console.Write("Qual case vc deseja entrar ?: ");
menu=int.Parse(Console.ReadLine());
switch (menu)
{
    
    case 1:
        do
            {
                Console.WriteLine("Você deseja adicionar uma tarefa nova ? s/n");
                e = char.Parse(Console.ReadLine());
                if (ConvertBooleano(e)) //if(E==true)
                {

                      Console.WriteLine("Qual o nome da sua nova tarefa: ");
                      string  nomeNovaTarefa = Console.ReadLine();
                      var resultadoBusca = l.Where(tarefa => tarefa.nome == nomeNovaTarefa);

                    // sintaxe .Where(variavel(variavel que sera criada dentro do where) (representa os itens da lista) => condicao);
                    if(resultadoBusca.Any()){
                        Console.WriteLine("Tarefa não criada, pois ja existe outra com este nome; ");
                    } else {
                         Console.WriteLine("Qual o esforço da sua nova tarefa: ");
                        int esforco = Convert.ToInt32(Console.ReadLine());

                        tarefas t = new tarefas();
                        t.gerarTarefa(nomeNovaTarefa, esforco);
                        l.Add(t);
                        imprimirTarefas(l);
                    }

                }
                else
                {
                    Console.WriteLine(" Nenhuma tarefa será adicionada! ");
                }
                Console.WriteLine("Você deseja interromper ? s/n");
                e= char.Parse(Console.ReadLine());
            } while (!ConvertBooleano(e));

        break;


    case 2:


    break;



    
    
    
}


void imprimirTarefas(List<tarefas> lista){
Console.WriteLine("Todas as suas tarefas: ");
 foreach (var item in lista)
 {
    Console.WriteLine($"Nome = {item.nome} Esforço = {item.esforco} (horas)");
 }
}

bool ConvertBooleano(char c){
    //if ternario condicao ? true : false;
    // return char.ToUpper(c) == 'S' ? true : false;

  /// ou  
  if(char.ToUpper(c) == 'S')
      return true;
    return false;

}