Assets/
├── _Project/                  <-- Tudo que você criar vai aqui dentro (evita misturar com pacotes externos)
│   ├── Animations/            <-- Controladores de animação (Animators) e clipes (.anim)
│   ├── Audio/
│   │   ├── Music/             <-- Trilhas sonoras
│   │   └── SFX/               <-- Efeitos sonoros (pulos, tiros, UI, etc.)
│   ├── Fonts/                 <-- Fontes de texto (TTF, OTF, TextMeshPro Assets)
│   ├── Materials/             <-- Materiais e Shaders customizados
│   ├── Models/                <-- Modelos 3D (FBX, OBJ) e suas texturas específicas
│   ├── Prefabs/               <-- Objetos reutilizáveis (Player, Inimigos, Itens, UI)
│   ├── Physics/               <-- Materiais de física (Physics Materials 2D/3D)
│   ├── Scenes/                <-- Suas cenas (Menu, Level_01, Level_02, etc.)
│   ├── Scripts/               <-- Todo o seu código C#
│   │   ├── Editor/            <-- Scripts que alteram a Unity Engine (não vão para o build)
│   │   ├── Gameplay/          <-- Lógica do jogo (Player, Enemy, Combat)
│   │   ├── Managers/          <-- Sistemas globais (GameManager, AudioManager)
│   │   └── UI/                <-- Controladores de interface
│   ├── Textures/              <-- Texturas gerais, UI, Spritesheets e Normal Maps
│   └── WebGLTemplates/        <-- (Opcional) Templates para builds de navegador
│
├── Plugins/                   <-- SDKs e ferramentas externas de código (ex: Steamworks, Firebase)
└── ThirdParty/                <-- Assets baixados da Unity Asset Store (mantém seu _Project limpo)
