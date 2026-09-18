Jogo jogo1 = new Jogo("Red Dead Redemption 2", "Ação-Aventura/Mundo Aberto", 2018);
Jogo jogo2 = new Jogo("The Last of Us", "Ação-aventura / Survival horror", 2013);
Jogo jogo3 = new Jogo("Call of Duty: Black Ops II", "Tiro em primeira pessoa (FPS) / Ação", 2012);

CatalogoJogos catalogo1 = new CatalogoJogos();
catalogo1.AdicionarJogo(jogo1);
catalogo1.AdicionarJogo(jogo2);
catalogo1.AdicionarJogo(jogo3);

catalogo1.ListarJogos();