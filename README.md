# Teste_DOTS
 Teste em Unity utilizando DOTS

* Para fazer o projeto foi utilizado.

* Unity versão 2019.4.40f1
* Foram utilizados os pacotes : Entites 0.11.2-preview.1
                                Hybrid Renderer 0.5.2-preview.4
                                Mathematics 1.1.0
                                Jobs 0.2.10-preview.13

* GIMP versão 2.10.34

# Planejamento

* O projeto foi pensado para ser um cenário com a câmera fixa
apontada para três entidades na frente, enquanto outras entidades
passam pelo cenário. As entidades seriam interagiveis através de
pointclick com o mouse.
Haveria quatro tipos de entidades para interagir, são elas:
Joia vermelha, joia amarela, joia azul e orbe flutuante, todas possuem
telas de informação que seria mostradas ao clicar em cada entidade.

Foi utilizado no projeto unit jobs e burst compiler para otimização.
Para demostrar a funcionalidade, foi utilizado uma ação de 100000 calculos
pesados na mainthread e comparado a velocidade dos calculos com uso de jobs
e burst compiler.
Foi feito uma interface no canto superior direito da tela para mostrar os
resultados dos testes, também é possivel habilitar e desabilitar as jobs
com o checkbox localizado no script acoplado na câmera. Também é possivel
alterar a quantidade de calculos na mesma inteface do inspector da câmera.


# Execução do projeto

* O projeto deve ser executado na própria Unity Editor, antes de executar o projeto
é recomendado alterar a quantidades de calculos em Calcs no inspector da Main Camera
no componente Calculo Pesado.


# Falhas

* A função de clicar nas entidades não esta funcionando, devido a inconsistencia ao 
utilizar o pacote de Unity Physics não foi possivel realizar colisão entre entidades.

É possivel ver as informações das entidades ao executar o projeto e habilitar manualmente
o objeto em canvas. Existem 4 objetos UI com o nome InfoBG que mostram as informações das
joias e orbe.



# Material de apoio

* Manual da Unity : https://docs.unity3d.com/Packages/com.unity.entities@1.1/manual/index.html

* Canal Code Monkey: https://www.youtube.com/@CodeMonkeyUnity

* Canal Turbo Makes Games: https://www.youtube.com/@TurboMakesGames