using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameText : MonoBehaviour
{

    // Descrição de cada parágrafo em uma array de strings que serão chamadas de acordo com as escolhas feitas durante o jogo


    // tutoTexts[17] - Range: 0~16
    public string[] tutoTexts = {
        "Deseja receber instruções? " ,
        
        "Antes de embarcar na aventura, você deve primeiro determinar suas forças e fraquezas. Use os dados para determinar o valor inicial de cada atributo, ou opte por valores pré-definidos que podem oferecer certo desafio ou vantagem para sua caminhada. ",
        
        "Os atributos em ToC definirão diversos fatores durante a aventura, como o quanto você é bom em acertar golpes, ou quantos golpes você aguenta levar antes de acabar sua jornada. Seus valores atuais não poderão exceder seus valores iniciais/máximos, exceto em ocasiões raras que podem ser encontradas durante o jogo. ",

        "PODER define sua habilidade de combate e sua força em geral, quanto maior, melhor. ENERGIA reflete sua constituição, sua vontade de viver, sua determinação e aptidão como um todo. Quanto mais pontos de ENERGIA, mais tempo você será capaz de sobreviver. Seus pontos de SORTE indicam o quão sortudo você é naturalmente. Com este atributo você pode mudar o resultado de alguma situação, ou piorá-lo, caso não seja tão sortudo assim. ",

        "Durante o Torneio dos Campeões, você enfrentará diversos monstros e inimigos, além de outros desafios. Quando o momento de lutar por sua vida chegar, os dados no canto inferior-direito da tela se tornarão ativos, de acordo com a necessidade. Use-os para fazer suas rolagens e definir suas falhas e sucessos. ",

        "Na tela serão exibidos os atributos da criatura que está enfrentando. A cada turno haverá uma contestação de 'Força de Ataque' entre você e seu(s) inimigo(s). O vencedor da contestação causa 2 de dano ao adversário, subtraindo este dano do valor atual de sua ENERGIA. O primeiro que esgotar sua ENERGIA é derrotado. ",

        "Em diversas ocasiões lhe será permitido o uso de SORTE para alterar certos resultados. Quando escolher usar sua SORTE, deverá realizar o procedimento conhecido como 'Teste sua Sorte', rolando dados-duplos. Se o valor adquirido for menor que seu valor [b]atual[/b] de SORTE, você foi sortudo e a situação correrá a seu favor. Se o valor for maior, você teve azar e terá que lidar com péssimas consequências. ",

        "Sempre que 'Testar sua Sorte', diminua seu valor atual de SORTE em 1, isto eventualmente dificultará novas situações sortudas. Portanto, tome cuidado para não depender demais de sua SORTE. ",

        "Em alguns momentos do jogo, será dito para que 'Teste sua Sorte' e as consequências em caso de sucesso ou falha. Contudo, durante o combate, você tem a opção de usar sua SORTE para agravar um ferimento causado por você, ou diminuir o dano causado a você por outra criatura. ",

        "Caso tenha acertado um ataque, 'Teste sua Sorte' e, caso seja sortudo, inflige um total de 4 de dano na ENERGIA do adversário. Contudo, caso seja azarado, causará apenas um total de 1 de dano, ao invés dos habituais 2 de dano em um ataque regular. ",

        "Se a criatura acertou um ataque em você, pode 'Testar sua Sorte' e, se tiver sorte, você conseguiu evitar parte do dano que lhe seria causado, recebendo apenas 1 de dano em sua ENERGIA. Se foi azarado, o golpe foi mais forte que esperava e você recebe 1 de dano adicional, além dos 2 de dano que receberia por um ataque bem sucedido de seu adversário. ",

        "Seus pontos de PODER não mudarão muito durante sua jornada Ocasionalmente certo ponto da história ou item pode aumentar ou diminuir os valores. O uso de uma Arma Mágica também pode aumentar seu PODER. ",

        "Sua ENERGIA mudará bastante durante a aventura, seja por combate ou realização de tarefas árduas. Durante o curso da história, você será apresentado a oportunidades para que recupere seus pontos de ENERGIA de várias maneiras. ",

        "Por fim, durante toda a aventura, serão concedidas adições a seus pontos de SORTE, quando for particularmente sortudo. ",

        "Estas foram todas as instruções necessárias para finalmente entrar no Torneio dos Campeões. Qualquer outra instrução será apresentada durante o momento certo, mas caso deseje relembrar estas instruções, basta acessar o menu de configurações a qualquer momento do jogo. ",

        "Deseja repetir as intruções ou está pronto para iniciar sua jornada? ",

        "Você já está pronto. Boa sorte na Prova dos Campeões! "
    };


    // introTexts[16] - Range: 0~15
    public string[] introTexts = {
        "É mais um dia quentíssimo e a temperatura no tombadilho escuro e pegajoso é insuportável. O ar está denso com o cheiro acre dos corpos suados. Não é permitido falar e o único barulho ouvido além do rangido monótono do navio, é o do metódico e agudo estalar do chicote, e do agoniado grito que se segue. ",

        "“Remem com mais força, seus cachorros!” grita o capataz caolho, assim que estala seu chicote mais uma vez. “Aproveitem esta viagem agradável enquanto podem, porque vão desejar estar de volta a bordo depois de um ou dois dias no lugar para onde estão indo!” ",

        "Acorrentado a um banco e se esforçando muito no remo que puxa com outros dois escravos da embarcação, sua mente vagueia de volta ao desafortunado dia há uma semana, quando foi capturado.  ",

        "Você tinha deixado Porto Blacksand num barco pequeno para navegar em direção sul, ao longo da costa da Baía das Ostras. Por azar, uma grande embarcação apareceu no horizonte, indo em sua direção. Ela deslizou firmemente para mais perto e não demorou muito para que seu barco fosse esmagado debaixo da proa e você fosse forçado a mergulhar no mar. ",

        "Não havia nada que pudesse fazer, a não ser subir pela corda que lhe foi lançada, já que seu barco tinha se tornado nada mais que uns poucos pedaços de madeira, flutuando sem rumo no mar. Seria inútil debater-se, uma vez que uma tripulação de 20 assassinos insensíveis o cercava. ",

        "Uma voz rude atrás deles ordenou-lhes que se dispersassem. Um homem feio, com cicatrizes no rosto, sorrindo maliciosamente e cuspindo no chão a saliva do fumo de mascar apareceu. Seus dentes eram quebrados e escuros, e uma lufada de mau cheiro de suas roupas sujas flutuou na brisa. ",

        "“Capitão Barletta sempre entrega as mercadorias. Você substituirá o homem que morreu ontem de chicotadas. Foi ótimo ter raptado um marinheiro Deve ser meu dia de sorte, mas não diria que é o seu”. O capitão soltou uma gargalhada, que era como uma longa exalação ruidosa e então gritou uma ordem para seu imediato. ",

        "“Leve este rato para ficar com os outros vermes lá embaixo.” ",

        "Desde aquele dia amaldiçoado, você permanece acorrentado, remando à beira de um colapso, rumo a um destino desconhecido. De repente, você escuta um grito de “Terra à vista!” e põe-se a imaginar que malefício lhe aguarda. Uma hora depois, sente o navio bater contra um quebra-mar e há muita gritaria até que ele finalmente atraca. ",

        "Você é arrancado do navio junto com os outros escravos e vê sob a luz brilhante do sol que está numa pequena ilha. No topo da ilha, fica um castelo sombrio e, próximo a ele, há um anfiteatro semi-destruído. Um homem vestindo uma armadura preta entrega uma bolsa de moedas ao Capitão Barletta. Satisfeito com seu pagamento, o ruidoso capitão manda seus homens de volta ao navio e você os vê partir. ",

        "O homem com a armadura preta dá um passo à frente, dizendo: “Vocês são agora propriedade de Lord Carnuss. É uma honra morrer para seu prazer na Arena da Morte, aqui na Ilha de Sangue. Somente um de vocês sobreviverá. Ele, ou ela, representará Lord Carnuss, em Fang, no próximo Torneio dos Campeões.” ",

        "“O Barão Sukumvit modificou seu labirinto mortal e está oferecendo agora 20.000 moedas de Ouro para quem atravessá-lo. É claro que Lord Carnuss vai ficar com o prêmio caso vocês atravessem, mas suas vidas serão poupadas.” ",

        "“A reputação do Barão Sukumvit sofreu imensamente no ano passado, quando uma pessoa conseguiu atravessar o labirinto; porém agora ele se gaba de que ninguém pode sobreviver a seu novo calabouço. Lord Carnuss gostaria que um de vocês fizesse Sukimvit engolir suas palavras. Vocês devem compreender que ele odeia a fama de seu irmão.” ",

        "“Agora, sigam-me.” ",

        "Você é conduzido para o castelo em cima da montanha, onde é trancafiado numa cela nas profundezas das câmaras inferiores. Quatro outros prisioneiros estão dividindo sua cela: um anão robusto, um orc, um vigoroso homem que medita e um careca grande e musculoso. ",

        "A atmosfera é horrível e poucas palavras são trocadas, enquanto cada um pondera sobre o combate iminente. Quarenta e dois escravos chegaram de navio e apenas um vai sobreviver. O prêmio duvidoso é entrar num labirinto mortal. "
    };


    // paragrafosGame[] - Range: 0~
    public string[] paragrafosGame = {
        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",
        
        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

        "",

    };

}
