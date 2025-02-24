using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            ExibirMenu();
            string escolha = Console.ReadLine();

            switch (escolha.ToLower())
            {
                case "1":
                    ExibirExemploAbrirNavegador();
                    break;
                case "2":
                    ExibirExemploNovaPagina();
                    break;
                case "3":
                    ExibirExemploNavegarSite();
                    break;
                case "4":
                    ExibirExemploClicarElemento();
                    break;
                case "5":
                    ExibirExemploDigitarTexto();
                    break;
                case "6":
                    ExibirExemploCapturarScreenshot();
                    break;
                case "7":
                    ExibirExemploWebScraping();
                    break;
                case "8":
                    ExibirExemploTesteSimples();
                    break;
                case "9":
                    ExibirExemploHeadlessTrueFalse();
                    break;
                case "10":
                    ExibirExemploTimeout();
                    break;
                case "11":
                    ExibirExemploAguardarRequisicoesCarregar();
                    break;
                case "12":
                    ExibirExemploAguardarPaginaCompleta();
                    break;
                case "13":
                    ExibirExemploAguardarSeletor();
                    break;
                case "14":
                    ExibirExemploTrabalharMultiplasPaginas();
                    break;
                case "15":
                    ExibirExemploPopUpsENovasJanelas();
                    break;
                case "16":
                    ExibirExemploConfigurarProxyAutenticacao();
                    break;
                case "17":
                    ExibirExemploExecutarJavaScriptPagina();
                    break;
                case "18":
                    ExibirExemploGerenciarCookies();
                    break;
                case "19":
                    ExibirExemploLidarComFrames();
                    break;
                case "20":
                    ExibirExemploGerenciarDownloadArquivos();
                    break;
                case "21":
                    ExibirExemploSimularEventosMouseTeclado();
                    break;
                case "22":
                    ExibirExemploDefinirTamanhoJanela();
                    break;
                case "23":
                    ExibirExemploAguardarNavegacao();
                    break;
                case "24":
                    ExibirExemploImportarFuncoesHelpers();
                    break;
                case "0":
                    continuar = false;
                    Console.WriteLine("Saindo do catálogo. Até logo!");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Pressione Enter para continuar...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void ExibirMenu()
    {
        Console.WriteLine("=== Manual Completo e Didático do Puppeteer ===");
        Console.WriteLine("1. Abrir um navegador");
        Console.WriteLine("2. Criar uma nova página/aba");
        Console.WriteLine("3. Navegar para um site");
        Console.WriteLine("4. Clicar em um elemento");
        Console.WriteLine("5. Digitar texto em um campo");
        Console.WriteLine("6. Capturar um screenshot");
        Console.WriteLine("7. Extrair dados (web scraping)");
        Console.WriteLine("8. Fazer um teste simples");
        Console.WriteLine("9. Configurar modo headless (true/false)");
        Console.WriteLine("10. Usar timeouts");
        Console.WriteLine("11. Aguardar requisições de página carregar");
        Console.WriteLine("12. Aguardar página inteira estar completa");
        Console.WriteLine("13. Aguardar por um seletor");
        Console.WriteLine("14. Trabalhar com múltiplas páginas");
        Console.WriteLine("15. Lidar com pop-ups e novas janelas");
        Console.WriteLine("16. Configurar proxy e autenticação");
        Console.WriteLine("17. Executar JavaScript na página");
        Console.WriteLine("18. Gerenciar cookies");
        Console.WriteLine("19. Lidar com frames (iframes)");
        Console.WriteLine("20. Gerenciar download de arquivos");
        Console.WriteLine("21. Simular eventos de mouse e teclado");
        Console.WriteLine("22. Definir tamanho da janela");
        Console.WriteLine("23. Aguardar navegação (esperar redirecionamentos)");
        Console.WriteLine("24. Importar e usar funções de helpers");
        Console.WriteLine("0. Sair");
        Console.WriteLine("\nDigite o número da opção desejada: ");
    }

    static void ExibirExemploAbrirNavegador()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Abrir um Navegador com Puppeteer ===");
        Console.WriteLine(@"// Importa a biblioteca Puppeteer para usar suas funcionalidades
            const puppeteer = require('puppeteer');

            // Função assíncrona para executar ações no navegador
            (async () => {
                // Abre uma instância do navegador Chrome/Chromium (headless por padrão, sem interface gráfica)
                const browser = await puppeteer.launch({ headless: false }); // headless: false mostra a interface gráfica
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploNovaPagina()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Criar uma Nova Página/Aba ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página (aba) no navegador
                const page = await browser.newPage();
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploNavegarSite()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Navegar para um Site ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site especificado (Google, neste caso)
                await page.goto('https://www.google.com');
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploClicarElemento()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Clicar em um Elemento ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site especificado
                await page.goto('https://exemplo.com');
                // Clica em um elemento da página usando um seletor CSS (ex.: botão com ID 'botaoLogin')
                await page.click('#botaoLogin'); // Substitua '#botaoLogin' pelo seletor real do elemento
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploDigitarTexto()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Digitar Texto em um Campo ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para uma página com formulário de login
                await page.goto('https://exemplo.com/login');
                // Digita texto no campo de e-mail usando um seletor CSS
                await page.type('#email', 'seuemail@example.com'); // Substitua '#email' pelo seletor real
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploCapturarScreenshot()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Capturar um Screenshot ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://www.google.com');
                // Captura um screenshot da página e salva como 'google.png'
                await page.screenshot({ path: 'google.png' });
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploWebScraping()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Extrair Dados (Web Scraping) ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://exemplo.com');
                // Executa código JavaScript na página para extrair o texto do elemento h1
                const texto = await page.evaluate(() => {
                    // Seleciona o elemento h1 e retorna seu texto interno
                    return document.querySelector('h1').innerText;
                });
                // Exibe o texto extraído no console
                console.log(texto);
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploTesteSimples()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Fazer um Teste Simples ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://exemplo.com');
                // Verifica se um elemento existe na página usando seu seletor
                const elementoExiste = await page.$('#elementoTeste') !== null;
                // Se o elemento existir, exibe mensagem de sucesso; caso contrário, exibe mensagem de erro
                if (elementoExiste) {
                    console.log('Elemento encontrado com sucesso!');
                } else {
                    console.log('Elemento não encontrado.');
                }
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploHeadlessTrueFalse()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Configurar Modo Headless (true/false) ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            // Exemplo com modo headless: true (sem interface gráfica)
            (async () => {
                // Abre uma instância do navegador em modo headless (não exibe a interface gráfica)
                const browser = await puppeteer.launch({ headless: true });
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://www.google.com');
                // Fecha o navegador após a execução
                await browser.close();
            })();

            // Exemplo com modo headless: false (com interface gráfica)
            (async () => {
                // Abre uma instância do navegador com interface gráfica visível
                const browser = await puppeteer.launch({ headless: false });
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://www.google.com');
                // Espera 5 segundos para visualizar a página antes de fechar
                await new Promise(r => setTimeout(r, 5000));
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploTimeout()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Usar Timeouts ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site com um timeout de 10 segundos (se a página não carregar nesse tempo, gera erro)
                await page.goto('https://www.google.com', { timeout: 10000 });
                // Pausa a execução por 2 segundos
                await page.waitForTimeout(2000);
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploAguardarRequisicoesCarregar()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Aguardar Requisicoes de Página Carregar ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site e espera até que não haja mais requisições de rede (networkidle0)
                await page.goto('https://exemplo.com', { waitUntil: 'networkidle0' });
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploAguardarPaginaCompleta()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Aguardar Página Inteira Estar Completa ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site e espera até o evento 'load' (página totalmente carregada)
                await page.goto('https://exemplo.com', { waitUntil: 'load' });
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploAguardarSeletor()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Aguardar por um Seletor ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://exemplo.com');
                // Aguarda até que o elemento com o seletor '#meuElemento' apareça na página
                await page.waitForSelector('#meuElemento');
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploTrabalharMultiplasPaginas()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Trabalhar com Múltiplas Páginas ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria duas novas páginas (abas)
                const page1 = await browser.newPage();
                const page2 = await browser.newPage();

                // Navega para o Google na primeira página
                await page1.goto('https://www.google.com');
                // Navega para o YouTube na segunda página
                await page2.goto('https://www.youtube.com');

                // Obtém o título de cada página
                const title1 = await page1.title(); // Pega o título da página 1
                const title2 = await page2.title(); // Pega o título da página 2
                // Exibe os títulos no console
                console.log('Título da página 1:', title1);
                console.log('Título da página 2:', title2);

                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploPopUpsENovasJanelas()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Lidar com Pop-ups e Novas Janelas ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();

                // Configura um listener para capturar pop-ups ou novas janelas
                page.on('popup', async (newPage) => {
                    // Exibe uma mensagem quando uma nova janela é detectada
                    console.log('Nova janela detectada!');
                    // Espera 2 segundos para visualizar a nova janela
                    await newPage.waitForTimeout(2000);
                    // Obtém o título da nova página
                    const newTitle = await newPage.title();
                    // Exibe o título no console
                    console.log('Título da nova janela:', newTitle);
                });

                // Navega para um site que pode abrir pop-ups (substitua pela URL real)
                await page.goto('https://exemplo.com/com-pop-up');
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploConfigurarProxyAutenticacao()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Configurar Proxy e Autenticação ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador configurando um proxy
                const browser = await puppeteer.launch({
                    args: ['--proxy-server=http://seu-proxy.com:8080'], // Substitua pelo seu proxy
                });
                // Cria uma nova página
                const page = await browser.newPage();

                // Configura autenticação para o proxy, se necessário
                await page.authenticate({
                    username: 'seu-usuario', // Substitua pelo seu usuário
                    password: 'sua-senha',   // Substitua pela sua senha
                });

                // Navega para o site
                await page.goto('https://www.google.com');
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploExecutarJavaScriptPagina()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Executar JavaScript na Página ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://exemplo.com');

                // Executa um código JavaScript na página para obter dimensões da janela
                const resultado = await page.evaluate(() => {
                    // Retorna um objeto com a largura e altura da janela
                    return { width: window.innerWidth, height: window.innerHeight };
                });
                // Exibe as dimensões no console
                console.log('Dimensões da janela:', resultado);

                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploGerenciarCookies()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Gerenciar Cookies ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://exemplo.com');

                // Obtém todos os cookies da página atual
                const cookies = await page.cookies();
                // Exibe os cookies no console
                console.log('Cookies:', cookies);

                // Adiciona um novo cookie à página
                await page.setCookie({
                    name: 'nomeCookie',      // Nome do cookie
                    value: 'valorCookie',    // Valor do cookie
                    domain: 'exemplo.com',   // Domínio onde o cookie será válido
                });

                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploLidarComFrames()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Lidar com Frames (iframes) ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para um site com iframes
                await page.goto('https://exemplo.com/com-iframe');

                // Obtém todos os frames da página
                const frames = await page.frames();
                // Acessa o frame pelo índice (ex.: o primeiro frame, índice 0)
                const frame = frames[0];

                // Interage com um elemento dentro do frame (usando seletor)
                const textoFrame = await frame.$eval('#elementoNoFrame', element => element.innerText);
                // Exibe o texto do frame no console
                console.log('Texto do frame:', textoFrame);

                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploGerenciarDownloadArquivos()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Gerenciar Download de Arquivos ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');
            const path = require('path');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Define o diretório para downloads
                const downloadPath = path.resolve('./downloads');
                await page._client.send('Page.setDownloadBehavior', { behavior: 'allow', downloadPath: downloadPath });

                // Navega para um site com link de download (substitua pela URL real)
                await page.goto('https://exemplo.com/download');
                // Clica em um link de download (usando seletor)
                await page.click('#linkDownload'); // Substitua '#linkDownload' pelo seletor real

                // Espera um tempo para o download concluir
                await page.waitForTimeout(5000);

                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploSimularEventosMouseTeclado()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Simular Eventos de Mouse e Teclado ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para o site
                await page.goto('https://exemplo.com');

                // Simula um clique em coordenadas específicas (x, y)
                await page.mouse.click(100, 200);

                // Simula digitação de texto usando o teclado
                await page.keyboard.type('Olá, Puppeteer!');

                // Simula pressionar Enter
                await page.keyboard.press('Enter');

                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploDefinirTamanhoJanela()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Definir Tamanho da Janela ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Define o tamanho da janela (largura e altura)
                await page.setViewport({ width: 1280, height: 800 });
                // Navega para o site
                await page.goto('https://www.google.com');
                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploAguardarNavegacao()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Aguardar Navegação (Esperar Redirecionamentos) ===");
        Console.WriteLine(@"const puppeteer = require('puppeteer');

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch();
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para um site que pode redirecionar
                await page.goto('https://exemplo.com/redirecionamento', { waitUntil: 'networkidle2' });
                // Aguarda até que a navegação (redirecionamento) esteja completa
                await page.waitForNavigation();
                // Obtém o URL final após redirecionamentos
                const urlFinal = page.url();
                console.log('URL final após navegação:', urlFinal);

                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }

    static void ExibirExemploImportarFuncoesHelpers()
    {
        Console.Clear();
        Console.WriteLine("=== Exemplo: Importar e Usar Funções de Helpers ===");
        Console.WriteLine(@"// Primeiro, crie um arquivo chamado 'helpers.js' com funções auxiliares:

            // Conteúdo de helpers.js
            const helpers = {
                // Função para clicar em um elemento com retry (tentativa)
                async clickWithRetry(page, selector, maxAttempts = 3) {
                    for (let attempt = 1; attempt <= maxAttempts; attempt++) {
                        try {
                            await page.waitForSelector(selector, { timeout: 5000 });
                            await page.click(selector);
                            console.log(`Clique em ${selector} realizado com sucesso na tentativa ${attempt}!`);
                            return;
                        } catch (error) {
                            console.log(`Tentativa ${attempt} falhou: ${error.message}`);
                            if (attempt === maxAttempts) throw new Error(`Falha ao clicar em ${selector} após ${maxAttempts} tentativas.`);
                            await new Promise(resolve => setTimeout(resolve, 1000)); // Espera 1 segundo antes de tentar novamente
                        }
                    }
                },

                // Função para preencher um campo com texto e verificar se foi preenchido
                async fillField(page, selector, text) {
                    await page.waitForSelector(selector);
                    await page.type(selector, text);
                    const value = await page.$eval(selector, el => el.value);
                    if (value !== text) throw new Error(`Campo ${selector} não foi preenchido corretamente.`);
                    console.log(`Campo ${selector} preenchido com: ${text}`);
                }
            };

            module.exports = helpers;

            // Agora, use essas funções em um script Puppeteer (exemplo: main.js):

            const puppeteer = require('puppeteer');
            const helpers = require('./helpers'); // Importa as funções de helpers.js

            (async () => {
                // Abre uma instância do navegador
                const browser = await puppeteer.launch({ headless: false });
                // Cria uma nova página
                const page = await browser.newPage();
                // Navega para um site com formulário
                await page.goto('https://exemplo.com/login');

                try {
                    // Usa a função clickWithRetry para clicar em um botão de login
                    await helpers.clickWithRetry(page, '#botaoLogin'); // Substitua '#botaoLogin' pelo seletor real

                    // Usa a função fillField para preencher o campo de e-mail
                    await helpers.fillField(page, '#email', 'seuemail@example.com'); // Substitua '#email' pelo seletor real

                    // Usa a função fillField para preencher o campo de senha
                    await helpers.fillField(page, '#password', 'suasenha123'); // Substitua '#password' pelo seletor real
                } catch (error) {
                    console.error('Erro ao executar as ações:', error.message);
                }

                // Fecha o navegador após a execução
                await browser.close();
            })();
            ");
        Console.WriteLine("\nPressione Enter para voltar ao menu...");
        Console.ReadLine();
    }
}