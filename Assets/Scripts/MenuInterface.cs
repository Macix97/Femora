﻿using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Controls actions related to the menu graphics interface and initialize GUI.
/// </summary>
public class MenuInterface : MonoBehaviour
{
    // Menu music manager
    private MenuMusicManager _menuMusicManager;
    // General
    public static readonly string MenuInterfaceController = "MenuInterfaceController";
    public static readonly string MenuController = "Menu Controller";

    // Class name ID
    public static readonly string ClassNameId = "ClassName";

    // Game scene
    public static readonly string GameScene = "Game";

    // Save slot
    public static readonly string Save = "Save0";

    // Colors
    public static readonly Color Gold = new Color(0.53f, 0.47f, 0.29f);
    public static readonly Color White = new Color(1f, 1f, 1f);

    // GUI Texts
    public static readonly string YouHaveTooManyCharacters = "You have too many characters!";
    public static readonly string YouHaveTypedWrongName = "You have typed wrong name!";
    public static readonly string TypeNameForHero = "Type name for your hero:";
    public static readonly string NameIsAlreadyTaken = "This name is already taken. Try insert another one.";
    public static readonly string TooManyHeroes = "You have too many heroes. Try delete some character.";
    public static readonly string UseOnlyAlphanumericSymbols = "Use only alphanumeric symbols!";
    public static readonly string ReturnToMainMenu = "Return to main menu";
    public static readonly string SelectSomeOption = "Select some option";
    public static readonly string ChooseYourClass = "Choose your class";
    public static readonly string NewGameText = "Start new adventure";
    public static readonly string LoadGameText = "Load saved game";
    public static readonly string CreditsText = "Informations about game";
    public static readonly string ExitFemoraText = "I'll be back!";
    public static readonly string PaladinDesc = "Holy warrior fighting with a sword";
    public static readonly string SettingsDesc = "Check game settings";
    public static readonly string SettingsMenuDesc = "Adjust game settings";

    // Panels
    public static readonly string ClassMenu = "ClassMenu";
    public static readonly string StatsMenu = "StatsMenu";
    public static readonly string CreateMenu = "CreateMenu";
    public static readonly string SettingsMenu = "SettingsMenu";
    public static readonly string CreditsMenu = "CreditsMenu";
    public static readonly string ErrorMenu = "ErrorMenu";
    public static readonly string LoadMenu = "LoadMenu";
    public static readonly string NewGame = "NewGamePanel";
    public static readonly string LoadGame = "LoadGamePanel";
    public static readonly string Credits = "CreditsPanel";
    public static readonly string Settings = "SettingsPanel";
    public static readonly string ExitFemora = "ExitFemoraPanel";
    public static readonly string AcceptHero = "AcceptHeroPanel";
    public static readonly string AnnulHero = "AnnulHeroPanel";
    public static readonly string NewBack = "NewBackPanel";
    public static readonly string CreateBack = "CreateBackPanel";
    public static readonly string LoadBack = "LoadBackPanel";
    public static readonly string ErrorBack = "ErrorBackPanel";
    public static readonly string CreditsBack = "CreditsBackPanel";
    public static readonly string SettingsBack = "SettingsBackPanel";
    public static readonly string WarningMenu = "WarningMenu";
    public static readonly string WarningBackPanel = "WarningBackPanel";

    // Images
    public static readonly string HeroBackground = "HeroBackground";
    public static readonly string HeroImage = "HeroImage";
    public static readonly string PaladinClass = "PaladinClassName";

    // Texts
    public static readonly string FemoraText = "FemoraText";

    public static readonly string LoadText = "LoadText";
    public static readonly string SettingsLabel = "SettingsLabel";
    public static readonly string CreateText = "CreateText";
    public static readonly string MenuHintText = "MenuHintText";
    public static readonly string StartingLevel = "StartingLevelText";
    public static readonly string StartingVitality = "StartingVitalityText";
    public static readonly string StartingWisdom = "StartingWisdomText";
    public static readonly string StartingStrength = "StartingStrengthText";
    public static readonly string StartingAgility = "StartingAgilityText";
    public static readonly string CurSoundsText = "CurSoundsText";
    public static readonly string CurMusicText = "CurMusicText";

    // Inputs
    public static readonly string NameInput = "NameInput";

    //--- Texts ---//

    // Femora
    public Text FemoraTxt { get; set; }
    // Settings
    public Text SettingsTxt { get; set; }
    // Load
    public Text LoadTxt { get; set; }
    // Create hint
    public Text CreateTxt { get; set; }
    // Menu hint
    public Text MenuHintTxt { get; set; }
    // Starting level
    public Text StartingLevelTxt { get; set; }
    // Starting vitality
    public Text StartingVitalityTxt { get; set; }
    // Starting wisdom
    public Text StartingWisdomTxt { get; set; }
    // Starting strength
    public Text StartingStrengthTxt { get; set; }
    // Starting agility
    public Text StartingAgilityTxt { get; set; }
    // Saves
    public Text[] Saves { get; set; }
    // Current sounds text
    public Text CurSoundsTxt { get; set; }
    // Current music text
    public Text CurMusicTxt { get; set; }

    //--- Sliders ---//

    public Slider SoundSliderSld { get; set; }
    public Slider MusicSliderSld { get; set; }

    //--- Images ---//

    // Hero background
    public Image HeroBackgroundImg { get; set; }
    // Hero image
    public Image HeroImageImg { get; set; }
    // Paladin class
    public Image PaladinClassImg { get; set; }
    // New game
    public Image NewGameImg { get; set; }
    // Load game
    public Image LoadGameImg { get; set; }
    // Settings
    public Image SettingsImg { get; set; }
    // Credits
    public Image CreditsImg { get; set; }
    // Exit Femora
    public Image ExitFemoraImg { get; set; }
    // Settings menu
    public Image SettingsMenuImg { get; set; }
    // Class menu
    public Image ClassMenuImg { get; set; }
    // Load menu
    public Image LoadMenuImg { get; set; }
    // Stats menu
    public Image StatsMenuImg { get; set; }
    // Create menu
    public Image CreateMenuImg { get; set; }
    // Credits menu
    public Image CreditsMenuImg { get; set; }
    // Error menu
    public Image ErrorMenuImg { get; set; }
    // Back button in new game
    public Image NewBackImg { get; set; }
    // Accept hero button
    public Image AcceptHeroImg { get; set; }
    // Back button in create menu
    public Image CreateBackImg { get; set; }
    // Annul button in create menu
    public Image AnnulHeroImg { get; set; }
    // Back button in load menu
    public Image LoadBackImg { get; set; }
    // Back button in credits menu
    public Image CreditsBackImg { get; set; }
    // Back button in settings menu
    public Image SettingsBackImg { get; set; }
    // Warning menu
    public Image WarningMenuImg { get; set; }

    //--- Inputs fields ---//

    // Name input field
    public InputField NameInputField { get; set; }

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        Init();
    }

    // Set basic parameters
    private void Init()
    {
        // Graphical elements
        HeroBackgroundImg = GameObject.Find(HeroBackground).GetComponent<Image>();
        HeroImageImg = GameObject.Find(HeroImage).GetComponent<Image>();
        NewGameImg = GameObject.Find(NewGame).GetComponent<Image>();
        LoadGameImg = GameObject.Find(LoadGame).GetComponent<Image>();
        SettingsImg = GameObject.Find(Settings).GetComponent<Image>();
        CreditsImg = GameObject.Find(Credits).GetComponent<Image>();
        ExitFemoraImg = GameObject.Find(ExitFemora).GetComponent<Image>();
        ClassMenuImg = GameObject.Find(ClassMenu).GetComponent<Image>();
        StatsMenuImg = GameObject.Find(StatsMenu).GetComponent<Image>();
        LoadMenuImg = GameObject.Find(LoadMenu).GetComponent<Image>();
        ErrorMenuImg = GameObject.Find(ErrorMenu).GetComponent<Image>();
        CreditsMenuImg = GameObject.Find(CreditsMenu).GetComponent<Image>();
        SettingsMenuImg = GameObject.Find(SettingsMenu).GetComponent<Image>();
        CreateMenuImg = GameObject.Find(CreateMenu).GetComponent<Image>();
        NewBackImg = GameObject.Find(NewBack).GetComponent<Image>();
        LoadBackImg = GameObject.Find(LoadBack).GetComponent<Image>();
        CreditsBackImg = GameObject.Find(CreditsBack).GetComponent<Image>();
        AcceptHeroImg = GameObject.Find(AcceptHero).GetComponent<Image>();
        AnnulHeroImg = GameObject.Find(AnnulHero).GetComponent<Image>();
        CreateBackImg = GameObject.Find(CreateBack).GetComponent<Image>();
        SettingsBackImg = GameObject.Find(SettingsBack).GetComponent<Image>();
        PaladinClassImg = GameObject.Find(PaladinClass).GetComponent<Image>();
        WarningMenuImg = GameObject.Find(WarningMenu).GetComponent<Image>();
        // Texts
        FemoraTxt = GameObject.Find(FemoraText).GetComponent<Text>();
        SettingsTxt = GameObject.Find(SettingsLabel).GetComponent<Text>();
        LoadTxt = GameObject.Find(LoadText).GetComponent<Text>();
        CreateTxt = GameObject.Find(CreateText).GetComponent<Text>();
        MenuHintTxt = GameObject.Find(MenuHintText).GetComponent<Text>();
        StartingLevelTxt = GameObject.Find(StartingLevel).GetComponent<Text>();
        StartingVitalityTxt = GameObject.Find(StartingVitality).GetComponent<Text>();
        StartingWisdomTxt = GameObject.Find(StartingWisdom).GetComponent<Text>();
        StartingStrengthTxt = GameObject.Find(StartingStrength).GetComponent<Text>();
        StartingAgilityTxt = GameObject.Find(StartingAgility).GetComponent<Text>();
        CurSoundsTxt = GameObject.Find(CurSoundsText).GetComponent<Text>();
        CurMusicTxt = GameObject.Find(CurMusicText).GetComponent<Text>();
        // Menu music manager
        _menuMusicManager = GameObject.Find(MenuController).GetComponent<MenuMusicManager>();
        // Sliders
        SoundSliderSld = GameObject.Find(GameInterface.SoundSlider).GetComponent<Slider>();
        MusicSliderSld = GameObject.Find(GameInterface.MusicSlider).GetComponent<Slider>();

        //--- Data loading ---//

        // Try load data
        SettingsDatabase.ConfigState configState = SettingsDatabase
            .TryLoadMenuFromFile(Application.persistentDataPath);
        // There are no configuration file
        if (configState.Equals(SettingsDatabase.ConfigState.NoFile))
            // Set default parameters from database
            SettingsDatabase.SetDefaultMenuSettings();
        // Configuration file is damaged
        else if (configState.Equals(SettingsDatabase.ConfigState.Error))
        {
            // Set default parameters from database
            SettingsDatabase.SetDefaultMenuSettings();
            // Hide main menu panels
            DeactivateElement(NewGameImg.transform);
            DeactivateElement(LoadGameImg.transform);
            DeactivateElement(SettingsImg.transform);
            DeactivateElement(CreditsImg.transform);
            DeactivateElement(ExitFemoraImg.transform);
            DeactivateElement(MenuHintTxt.transform.parent);
        }

        // Configuration load correctly!

        // Set reference to this script (needed to apply changes)
        MenuInterface menuInterface = this;
        // Set parameters from configuration file (default or saved)
        SettingsDatabase.ReadMenuFromConfig(ref menuInterface);
        // Add event listeners
        SoundSliderSld.onValueChanged.AddListener(delegate { _menuMusicManager.AdaptSoundsVolume(); });
        MusicSliderSld.onValueChanged.AddListener(delegate { _menuMusicManager.AdaptMusicVolume(); });
        // Set proper texts
        CreateTxt.text = TypeNameForHero;
        MenuHintTxt.text = SelectSomeOption;
        // Inputs fields
        NameInputField = GameObject.Find(NameInput).GetComponent<InputField>();
        // Add event listener
        NameInputField.onValueChanged.AddListener(delegate { CheckNameChange(); });
        // Update sliders labels
        _menuMusicManager.AdaptSoundsVolume();
        _menuMusicManager.AdaptMusicVolume();
        // Initialize saves
        Saves = new Text[SettingsDatabase.HeroesLimit];
        // Saves
        for (int cnt = 0; cnt < SettingsDatabase.HeroesLimit; cnt++)
        {
            Saves[cnt] = GameObject.Find(Save + cnt).GetComponentInChildren<Text>();
            // Change slot text
            Saves[cnt].text = ItemClass.EmptySpace;
            // Hide crosses
            HideMenuCrosses(Saves[cnt].transform.parent);
        }
        // Hide elements
        HideMenuCrosses(PaladinClassImg.transform);
        DeactivateElement(CreateBackImg.transform);
        DeactivateElement(SettingsBackImg.transform);
        DeactivateElement(AcceptHeroImg.transform);
        DeactivateElement(PaladinClassImg.transform);
        DeactivateElement(LoadMenuImg.transform);
        DeactivateElement(ClassMenuImg.transform);
        DeactivateElement(StatsMenuImg.transform);
        DeactivateElement(NewBackImg.transform);
        DeactivateElement(LoadBackImg.transform);
        DeactivateElement(CreditsBackImg.transform);
        DeactivateElement(HeroImageImg.transform);
        DeactivateElement(HeroBackgroundImg.transform);
        DeactivateElement(CreateMenuImg.transform);
        DeactivateElement(SettingsMenuImg.transform);
        DeactivateElement(ErrorMenuImg.transform);
        DeactivateElement(CreditsMenuImg.transform);
        DeactivateElement(LoadTxt.transform);
        // There is no configuration file or is correct (hide warning)
        if (!configState.Equals(SettingsDatabase.ConfigState.Error))
            DeactivateElement(WarningMenuImg.transform);
        // Create saves folder
        CreateSavesFolder();
        // Set properties
        Cursor.SetCursor(CursorDatabase.Pointers[0].Texture, Vector2.zero, CursorMode.Auto);
    }

    /// <summary>
    /// Activates selected UI element.
    /// </summary>
    /// <param name="trans">A transform that represents the UI element.</param>
    public void ActivateElement(Transform trans)
    {
        // Set visibility
        trans.gameObject.SetActive(true);
    }

    /// <summary>
    /// Deactivates selected UI element.
    /// </summary>
    /// <param name="trans">A transform that represents the UI element.</param>
    public void DeactivateElement(Transform trans)
    {
        // Set visibility
        trans.gameObject.SetActive(false);
    }

    /// <summary>
    /// Sets gold color for the selected text.
    /// </summary>
    /// <param name="panel">A transform that represents the UI element.</param>
    public void SetGoldText(Transform panel)
    {
        // Set gold color
        panel.GetComponentInChildren<Text>().color = Gold;
    }

    /// <summary>
    /// Sets white color for the selected text.
    /// </summary>
    /// <param name="panel">A transform that represents the UI element.</param>
    public void SetWhiteText(Transform panel)
    {
        // Set white color
        panel.GetComponentInChildren<Text>().color = White;
    }

    /// <summary>
    /// Shows crosses next to the selected label in the menu.
    /// </summary>
    /// <param name="panel">A transform that represents a panel.</param>
    public void ShowMenuCrosses(Transform panel)
    {
        // Show left cross
        panel.GetChild(0).gameObject.SetActive(true);
        // Show right cross
        panel.GetChild(1).gameObject.SetActive(true);
    }

    /// <summary>
    /// Hides crosses next to the selected label in the menu.
    /// </summary>
    /// <param name="panel">A transform that represents a panel.</param>
    public void HideMenuCrosses(Transform panel)
    {
        // Hide left cross
        panel.GetChild(0).gameObject.SetActive(false);
        // Hide right cross
        panel.GetChild(1).gameObject.SetActive(false);
    }

    /// <summary>
    /// Creates saves folder when the game is starting
    /// </summary>
    public void CreateSavesFolder()
    {
        // Check if folder exist
        if (!Directory.Exists(Application.persistentDataPath + SettingsDatabase.Saves))
            // Create directory
            Directory.CreateDirectory(Application.persistentDataPath + SettingsDatabase.Saves);
    }

    /// <summary>
    /// Checks if the content of the text input is changing.
    /// </summary>
    public void CheckNameChange()
    {
        // Check if name contains at least two characters
        if (NameInputField.text.Length < 2)
            // Hide accept hero button
            DeactivateElement(AcceptHeroImg.transform);
        // Name has at least two characters
        else
            // Show accept hero button
            ActivateElement(AcceptHeroImg.transform);
    }

    /// <summary>
    /// Checks if the inserted hero name is correct.
    /// </summary>
    /// <param name="name">A label that represents the name of the hero.</param>
    public void CheckNameCorrectness(string name)
    {
        // Check if hero directory already axists in saves folder
        if (Directory.Exists(Application.persistentDataPath + SettingsDatabase.Saves + name))
        {
            // Show back to create menu button
            ActivateElement(CreateBackImg.transform);
            // Hide accept hero button
            DeactivateElement(AcceptHeroImg.transform);
            // Hide annul create hero button
            DeactivateElement(AnnulHeroImg.transform);
            // Clear input field
            NameInputField.text = ItemClass.EmptySpace;
            // Hide input field
            DeactivateElement(NameInputField.transform);
            // Set proper info text
            CreateTxt.text = NameIsAlreadyTaken;
            // Change info text postion
            CreateTxt.transform.localPosition = new Vector3(CreateTxt.transform.localPosition.x,
                CreateTxt.transform.localPosition.y / 2, CreateTxt.transform.localPosition.z);
            // Break action
            return;
        }
        // Check if character limit is reached
        else if (Directory.GetDirectories(Application.persistentDataPath + SettingsDatabase.Saves)
            .Length > SettingsDatabase.HeroesLimit)
        {
            // Show back to create menu button
            ActivateElement(CreateBackImg.transform);
            // Hide accept hero button
            DeactivateElement(AcceptHeroImg.transform);
            // Hide annul create hero button
            DeactivateElement(AnnulHeroImg.transform);
            // Clear input field
            NameInputField.text = ItemClass.EmptySpace;
            // Hide input field
            DeactivateElement(NameInputField.transform);
            // Set proper info text
            CreateTxt.text = TooManyHeroes;
            // Change info text postion
            CreateTxt.transform.localPosition = new Vector3(CreateTxt.transform.localPosition.x,
                CreateTxt.transform.localPosition.y / 2, CreateTxt.transform.localPosition.z);
            // Break action
            return;
        }
        // Show load info
        ActivateElement(LoadTxt.transform);
        // Hide proper elements
        DeactivateElement(ClassMenuImg.transform);
        DeactivateElement(CreateMenuImg.transform);
        DeactivateElement(StatsMenuImg.transform);
        DeactivateElement(HeroBackgroundImg.transform);
        DeactivateElement(NewBackImg.transform);
        DeactivateElement(MenuHintTxt.transform.parent);
        // Create new character folder
        Directory.CreateDirectory(Application.persistentDataPath + SettingsDatabase.Saves + name);
        // Save hero name to variable in database
        SettingsDatabase.HeroName = name;
        // Copy variables to configuration structure
        SettingsDatabase.CopyMenuToConfig(_menuMusicManager);
        // Save configuration
        SettingsDatabase.TrySaveMenuToFile(Application.persistentDataPath);
        // Load game scene
        SceneManager.LoadScene(GameScene, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }

    /// <summary>
    /// Activates load menu after clicking the proper button.
    /// </summary>
    public void ActivateLoadMenu()
    {
        // Show proper elements
        ActivateElement(LoadMenuImg.transform);
        ActivateElement(LoadBackImg.transform);
        // Hide proper elements
        DeactivateElement(NewGameImg.transform);
        DeactivateElement(LoadGameImg.transform);
        DeactivateElement(SettingsImg.transform);
        DeactivateElement(CreditsImg.transform);
        DeactivateElement(ExitFemoraImg.transform);
        DeactivateElement(FemoraTxt.transform);
        DeactivateElement(MenuHintTxt.transform.parent);
        // Get directories in save folder
        string[] saveFolders = Directory.GetDirectories(Application.persistentDataPath + SettingsDatabase.Saves);
        // Check if some folder exists
        if (saveFolders.Equals(null))
            // Break action
            return;
        // Search save slots
        for (int cnt = 0; cnt < saveFolders.Length; cnt++)
            // Get save slot and set proper text
            Saves[cnt].text = saveFolders[cnt].Substring(saveFolders[cnt].LastIndexOf("/") + 1);
    }

    /// <summary>
    /// Loads the game progress from the proper file.
    /// </summary>
    /// <param name="contents">A label that represents the name of the directory for the proper hero.</param>
    public void LoadGameProgress(string contents)
    {
        // Check if data is loaded
        if (!SettingsDatabase.TryLoadGameFromFile(Application.persistentDataPath
            + SettingsDatabase.Saves + contents + SettingsDatabase.GameProgress
            + SettingsDatabase.DatFormat))
        {
            // Show proper elements
            ActivateElement(ErrorMenuImg.transform);
            // Hide proper elements
            DeactivateElement(LoadBackImg.transform);
            // Break action
            return;
        }
        // Show load info
        ActivateElement(LoadTxt.transform);
        // Hide proper elements
        DeactivateElement(LoadBackImg.transform);
        DeactivateElement(LoadMenuImg.transform);
        // Copy variables to configuration structure
        SettingsDatabase.CopyMenuToConfig(_menuMusicManager);
        // Save configuration
        SettingsDatabase.TrySaveMenuToFile(Application.persistentDataPath);
        // Load game scene
        SceneManager.LoadScene(GameScene, LoadSceneMode.Single);
    }
}