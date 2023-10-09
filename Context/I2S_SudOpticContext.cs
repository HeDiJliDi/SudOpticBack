using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sud_Optic_Api.Models;

namespace Sud_Optic_Api.Context;

public partial class I2S_SudOpticContext : DbContext
{
    public I2S_SudOpticContext()
    {
    }

    public I2S_SudOpticContext(DbContextOptions<I2S_SudOpticContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aa> Aas { get; set; }

    public virtual DbSet<AcodeBare> AcodeBares { get; set; }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<ArticleCodeBarre> ArticleCodeBarres { get; set; }

    public virtual DbSet<ArticleDefectueuseDansValise> ArticleDefectueuseDansValises { get; set; }

    public virtual DbSet<ArticleNumeroSerie> ArticleNumeroSeries { get; set; }

    public virtual DbSet<ArticleParFournisseur> ArticleParFournisseurs { get; set; }

    public virtual DbSet<ArticleTerminal> ArticleTerminals { get; set; }

    public virtual DbSet<Articlee> Articlees { get; set; }

    public virtual DbSet<Assurance> Assurances { get; set; }

    public virtual DbSet<AvanceClient> AvanceClients { get; set; }

    public virtual DbSet<AvanceFournisseur> AvanceFournisseurs { get; set; }

    public virtual DbSet<AvoirAchat> AvoirAchats { get; set; }

    public virtual DbSet<AvoirVente> AvoirVentes { get; set; }

    public virtual DbSet<Banque> Banques { get; set; }

    public virtual DbSet<BanqueSociete> BanqueSocietes { get; set; }

    public virtual DbSet<Bic> Bics { get; set; }

    public virtual DbSet<BonCommandeAchat> BonCommandeAchats { get; set; }

    public virtual DbSet<BonCommandeVente> BonCommandeVentes { get; set; }

    public virtual DbSet<BonEntrer> BonEntrers { get; set; }

    public virtual DbSet<BonLivraisonAchat> BonLivraisonAchats { get; set; }

    public virtual DbSet<BonLivraisonVente> BonLivraisonVentes { get; set; }

    public virtual DbSet<BonRetourAchat> BonRetourAchats { get; set; }

    public virtual DbSet<BonRetourLivreur> BonRetourLivreurs { get; set; }

    public virtual DbSet<BonRetourVente> BonRetourVentes { get; set; }

    public virtual DbSet<BonSortie> BonSorties { get; set; }

    public virtual DbSet<BonSortieLivreur> BonSortieLivreurs { get; set; }

    public virtual DbSet<BonTransfert> BonTransferts { get; set; }

    public virtual DbSet<BonTransformation> BonTransformations { get; set; }

    public virtual DbSet<BordereauEscompte> BordereauEscomptes { get; set; }

    public virtual DbSet<BordereauVersement> BordereauVersements { get; set; }

    public virtual DbSet<Calibre> Calibres { get; set; }

    public virtual DbSet<Camion> Camions { get; set; }

    public virtual DbSet<CauseAnnulationReservation> CauseAnnulationReservations { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientArticle> ClientArticles { get; set; }

    public virtual DbSet<ClientPassager> ClientPassagers { get; set; }

    public virtual DbSet<CommutionRepresentant> CommutionRepresentants { get; set; }

    public virtual DbSet<CompensationReglementClient> CompensationReglementClients { get; set; }

    public virtual DbSet<CompensationReglementFournisseur> CompensationReglementFournisseurs { get; set; }

    public virtual DbSet<Compte> Comptes { get; set; }

    public virtual DbSet<CompteurPiece> CompteurPieces { get; set; }

    public virtual DbSet<ConditionReglement> ConditionReglements { get; set; }

    public virtual DbSet<ContratClient> ContratClients { get; set; }

    public virtual DbSet<CopieTable> CopieTables { get; set; }

    public virtual DbSet<Couleur> Couleurs { get; set; }

    public virtual DbSet<CourbeArticle> CourbeArticles { get; set; }

    public virtual DbSet<DemandePrix> DemandePrixes { get; set; }

    public virtual DbSet<Depence> Depences { get; set; }

    public virtual DbSet<Depot> Depots { get; set; }

    public virtual DbSet<DetailDepence> DetailDepences { get; set; }

    public virtual DbSet<DetailReglementClient> DetailReglementClients { get; set; }

    public virtual DbSet<DetailReglementEscompte> DetailReglementEscomptes { get; set; }

    public virtual DbSet<DetailReglementFournisseur> DetailReglementFournisseurs { get; set; }

    public virtual DbSet<DetailReglementLivreur> DetailReglementLivreurs { get; set; }

    public virtual DbSet<DetailTransfert> DetailTransferts { get; set; }

    public virtual DbSet<DetailVersement> DetailVersements { get; set; }

    public virtual DbSet<DevisVente> DevisVentes { get; set; }

    public virtual DbSet<DroitAcce> DroitAcces { get; set; }

    public virtual DbSet<EditionSuivieMouvementStock> EditionSuivieMouvementStocks { get; set; }

    public virtual DbSet<EntetRemplacementClient> EntetRemplacementClients { get; set; }

    public virtual DbSet<Etat> Etats { get; set; }

    public virtual DbSet<EtuiBonLivraisonVente> EtuiBonLivraisonVentes { get; set; }

    public virtual DbSet<ExonerationClient> ExonerationClients { get; set; }

    public virtual DbSet<Exportation> Exportations { get; set; }

    public virtual DbSet<FactureAchat> FactureAchats { get; set; }

    public virtual DbSet<FactureAchatDiver> FactureAchatDivers { get; set; }

    public virtual DbSet<FactureExport> FactureExports { get; set; }

    public virtual DbSet<FactureExportTnd> FactureExportTnds { get; set; }

    public virtual DbSet<FactureVente> FactureVentes { get; set; }

    public virtual DbSet<FamilleArticle> FamilleArticles { get; set; }

    public virtual DbSet<FamilleClient> FamilleClients { get; set; }

    public virtual DbSet<FamilleFournisseur> FamilleFournisseurs { get; set; }

    public virtual DbSet<FicheIntervention> FicheInterventions { get; set; }

    public virtual DbSet<Fonction> Fonctions { get; set; }

    public virtual DbSet<FormeJuridique> FormeJuridiques { get; set; }

    public virtual DbSet<Fournisseur> Fournisseurs { get; set; }

    public virtual DbSet<FournisseurArticle> FournisseurArticles { get; set; }

    public virtual DbSet<FournisseurPassager> FournisseurPassagers { get; set; }

    public virtual DbSet<FraisPrixExport> FraisPrixExports { get; set; }

    public virtual DbSet<HistoriqueSoldeClient> HistoriqueSoldeClients { get; set; }

    public virtual DbSet<Iban> Ibans { get; set; }

    public virtual DbSet<ImageBonCommandevente> ImageBonCommandeventes { get; set; }

    public virtual DbSet<ImageClient> ImageClients { get; set; }

    public virtual DbSet<ImageFicheIntervention> ImageFicheInterventions { get; set; }

    public virtual DbSet<ImpayeClient> ImpayeClients { get; set; }

    public virtual DbSet<ImpayeClientNonPayee> ImpayeClientNonPayees { get; set; }

    public virtual DbSet<ImpayeFournisseur> ImpayeFournisseurs { get; set; }

    public virtual DbSet<ImportationComptable> ImportationComptables { get; set; }

    public virtual DbSet<ImpressionCreditSociete> ImpressionCreditSocietes { get; set; }

    public virtual DbSet<Incoterme> Incotermes { get; set; }

    public virtual DbSet<Intervenant> Intervenants { get; set; }

    public virtual DbSet<IntervenantParFiche> IntervenantParFiches { get; set; }

    public virtual DbSet<Inventaire> Inventaires { get; set; }

    public virtual DbSet<LettragePourCommussion> LettragePourCommussions { get; set; }

    public virtual DbSet<LigneAvoirAchat> LigneAvoirAchats { get; set; }

    public virtual DbSet<LigneAvoirVente> LigneAvoirVentes { get; set; }

    public virtual DbSet<LigneBonCommandeAchat> LigneBonCommandeAchats { get; set; }

    public virtual DbSet<LigneBonCommandeVente> LigneBonCommandeVentes { get; set; }

    public virtual DbSet<LigneBonCommandeVenteAndroid> LigneBonCommandeVenteAndroids { get; set; }

    public virtual DbSet<LigneBonEntrer> LigneBonEntrers { get; set; }

    public virtual DbSet<LigneBonLivraisonAchat> LigneBonLivraisonAchats { get; set; }

    public virtual DbSet<LigneBonLivraisonVente> LigneBonLivraisonVentes { get; set; }

    public virtual DbSet<LigneBonRetourAchat> LigneBonRetourAchats { get; set; }

    public virtual DbSet<LigneBonRetourLivreur> LigneBonRetourLivreurs { get; set; }

    public virtual DbSet<LigneBonRetourVente> LigneBonRetourVentes { get; set; }

    public virtual DbSet<LigneBonSortie> LigneBonSorties { get; set; }

    public virtual DbSet<LigneBonSortieLivreur> LigneBonSortieLivreurs { get; set; }

    public virtual DbSet<LigneBonTransfert> LigneBonTransferts { get; set; }

    public virtual DbSet<LigneBonTransformation> LigneBonTransformations { get; set; }

    public virtual DbSet<LigneBordereauEscompte> LigneBordereauEscomptes { get; set; }

    public virtual DbSet<LigneBordereauVersement> LigneBordereauVersements { get; set; }

    public virtual DbSet<LigneCommutionRepresentant> LigneCommutionRepresentants { get; set; }

    public virtual DbSet<LigneContratClient> LigneContratClients { get; set; }

    public virtual DbSet<LigneDemandePrix> LigneDemandePrixes { get; set; }

    public virtual DbSet<LigneDevisVente> LigneDevisVentes { get; set; }

    public virtual DbSet<LigneExportation> LigneExportations { get; set; }

    public virtual DbSet<LigneFactureAchat> LigneFactureAchats { get; set; }

    public virtual DbSet<LigneFactureAchatDiver> LigneFactureAchatDivers { get; set; }

    public virtual DbSet<LigneFactureExport> LigneFactureExports { get; set; }

    public virtual DbSet<LigneFactureExportTnd> LigneFactureExportTnds { get; set; }

    public virtual DbSet<LigneFactureVente> LigneFactureVentes { get; set; }

    public virtual DbSet<LigneFicheIntervention> LigneFicheInterventions { get; set; }

    public virtual DbSet<LigneInventaire> LigneInventaires { get; set; }

    public virtual DbSet<LigneObjectifRepresentantParQuantite> LigneObjectifRepresentantParQuantites { get; set; }

    public virtual DbSet<LigneObjectifSemaine> LigneObjectifSemaines { get; set; }

    public virtual DbSet<LignePreFacture> LignePreFactures { get; set; }

    public virtual DbSet<LigneReglementClient> LigneReglementClients { get; set; }

    public virtual DbSet<LigneReglementFournisseur> LigneReglementFournisseurs { get; set; }

    public virtual DbSet<LigneRetenuFactureAchat> LigneRetenuFactureAchats { get; set; }

    public virtual DbSet<LigneRetenuFactureVente> LigneRetenuFactureVentes { get; set; }

    public virtual DbSet<LigneValidationBonLivraisonVente> LigneValidationBonLivraisonVentes { get; set; }

    public virtual DbSet<LigneValidationDecaissement> LigneValidationDecaissements { get; set; }

    public virtual DbSet<ListeArticleStockZeroEtdemanderParClient> ListeArticleStockZeroEtdemanderParClients { get; set; }

    public virtual DbSet<ListeBlBr> ListeBlBrs { get; set; }

    public virtual DbSet<Livreur> Livreurs { get; set; }

    public virtual DbSet<Lot> Lots { get; set; }

    public virtual DbSet<MarqueArticle> MarqueArticles { get; set; }

    public virtual DbSet<MenuControle> MenuControles { get; set; }

    public virtual DbSet<ModeReglement> ModeReglements { get; set; }

    public virtual DbSet<MontureAtransformerEnSav> MontureAtransformerEnSavs { get; set; }

    public virtual DbSet<MouvementCompte> MouvementComptes { get; set; }

    public virtual DbSet<NatureIntervention> NatureInterventions { get; set; }

    public virtual DbSet<NotreBanque> NotreBanques { get; set; }

    public virtual DbSet<ObjectifRepresentantParQuantite> ObjectifRepresentantParQuantites { get; set; }

    public virtual DbSet<ObjectifSemaine> ObjectifSemaines { get; set; }

    public virtual DbSet<ObjectifparZone> ObjectifparZones { get; set; }

    public virtual DbSet<OldRetenuFactureAchat> OldRetenuFactureAchats { get; set; }

    public virtual DbSet<OldRetenuFactureVente> OldRetenuFactureVentes { get; set; }

    public virtual DbSet<OperationTresorerie> OperationTresoreries { get; set; }

    public virtual DbSet<OrderDepotDemande> OrderDepotDemandes { get; set; }

    public virtual DbSet<ParametreDiver> ParametreDivers { get; set; }

    public virtual DbSet<PreFacture> PreFactures { get; set; }

    public virtual DbSet<Preference> Preferences { get; set; }

    public virtual DbSet<Presentation> Presentations { get; set; }

    public virtual DbSet<Qt27> Qt27s { get; set; }

    public virtual DbSet<QuantiteSav05052023> QuantiteSav05052023s { get; set; }

    public virtual DbSet<RaisonBlocageClient> RaisonBlocageClients { get; set; }

    public virtual DbSet<RapportSuivie> RapportSuivies { get; set; }

    public virtual DbSet<ReceptionMateriel> ReceptionMateriels { get; set; }

    public virtual DbSet<RegionClient> RegionClients { get; set; }

    public virtual DbSet<ReglementClient> ReglementClients { get; set; }

    public virtual DbSet<ReglementEscompte> ReglementEscomptes { get; set; }

    public virtual DbSet<ReglementFournisseur> ReglementFournisseurs { get; set; }

    public virtual DbSet<ReglementTemporaire> ReglementTemporaires { get; set; }

    public virtual DbSet<RemplacementClient> RemplacementClients { get; set; }

    public virtual DbSet<RemplacementFournisseur> RemplacementFournisseurs { get; set; }

    public virtual DbSet<RemplacementPiece> RemplacementPieces { get; set; }

    public virtual DbSet<RendezVou> RendezVous { get; set; }

    public virtual DbSet<ReservationArticleDansDepot> ReservationArticleDansDepots { get; set; }

    public virtual DbSet<RetenuFactureAchat> RetenuFactureAchats { get; set; }

    public virtual DbSet<RetenuFactureVente> RetenuFactureVentes { get; set; }

    public virtual DbSet<RetenuReglementClient> RetenuReglementClients { get; set; }

    public virtual DbSet<RetenuReglementFournisseur> RetenuReglementFournisseurs { get; set; }

    public virtual DbSet<RetenuSource> RetenuSources { get; set; }

    public virtual DbSet<RetourReglement> RetourReglements { get; set; }

    public virtual DbSet<SaisieFicheClient> SaisieFicheClients { get; set; }

    public virtual DbSet<Semaine> Semaines { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Sexe> Sexes { get; set; }

    public virtual DbSet<Societe> Societes { get; set; }

    public virtual DbSet<SoldeClient> SoldeClients { get; set; }

    public virtual DbSet<SoldesClient> SoldesClients { get; set; }

    public virtual DbSet<SousFamilleArticle> SousFamilleArticles { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<StockAuDate> StockAuDates { get; set; }

    public virtual DbSet<StockDémarrage> StockDémarrages { get; set; }

    public virtual DbSet<StockTailleCouleur> StockTailleCouleurs { get; set; }

    public virtual DbSet<StockTemporaire> StockTemporaires { get; set; }

    public virtual DbSet<SuivieRepresantant> SuivieRepresantants { get; set; }

    public virtual DbSet<SuprimerMoi> SuprimerMois { get; set; }

    public virtual DbSet<Tabless> Tablesses { get; set; }

    public virtual DbSet<TailleCouleurLigneAvoirAchat> TailleCouleurLigneAvoirAchats { get; set; }

    public virtual DbSet<TailleCouleurLigneAvoirVente> TailleCouleurLigneAvoirVentes { get; set; }

    public virtual DbSet<TailleCouleurLigneBonCommandeAchat> TailleCouleurLigneBonCommandeAchats { get; set; }

    public virtual DbSet<TailleCouleurLigneBonCommandeVente> TailleCouleurLigneBonCommandeVentes { get; set; }

    public virtual DbSet<TailleCouleurLigneBonEntrer> TailleCouleurLigneBonEntrers { get; set; }

    public virtual DbSet<TailleCouleurLigneBonLivraisonAchat> TailleCouleurLigneBonLivraisonAchats { get; set; }

    public virtual DbSet<TailleCouleurLigneBonLivraisonVente> TailleCouleurLigneBonLivraisonVentes { get; set; }

    public virtual DbSet<TailleCouleurLigneBonSortie> TailleCouleurLigneBonSorties { get; set; }

    public virtual DbSet<TailleCouleurLigneBonTransfert> TailleCouleurLigneBonTransferts { get; set; }

    public virtual DbSet<TailleCouleurLigneDevisVente> TailleCouleurLigneDevisVentes { get; set; }

    public virtual DbSet<TailleCouleurLigneFactureAchat> TailleCouleurLigneFactureAchats { get; set; }

    public virtual DbSet<TailleCouleurLigneFactureVente> TailleCouleurLigneFactureVentes { get; set; }

    public virtual DbSet<TailleCouleurLigneInventaire> TailleCouleurLigneInventaires { get; set; }

    public virtual DbSet<TailleCouleurLigneOrdreFabrication> TailleCouleurLigneOrdreFabrications { get; set; }

    public virtual DbSet<TemporaireSuivieStock> TemporaireSuivieStocks { get; set; }

    public virtual DbSet<Tracabilite> Tracabilites { get; set; }

    public virtual DbSet<TraceAvanceClient> TraceAvanceClients { get; set; }

    public virtual DbSet<TraceAvanceFournisseur> TraceAvanceFournisseurs { get; set; }

    public virtual DbSet<TraceAvoirAchat> TraceAvoirAchats { get; set; }

    public virtual DbSet<TraceAvoirVente> TraceAvoirVentes { get; set; }

    public virtual DbSet<TraceBonCommandeAchat> TraceBonCommandeAchats { get; set; }

    public virtual DbSet<TraceBonCommandeVente> TraceBonCommandeVentes { get; set; }

    public virtual DbSet<TraceBonEntrer> TraceBonEntrers { get; set; }

    public virtual DbSet<TraceBonLivraisonAchat> TraceBonLivraisonAchats { get; set; }

    public virtual DbSet<TraceBonLivraisonVente> TraceBonLivraisonVentes { get; set; }

    public virtual DbSet<TraceBonRetourAchat> TraceBonRetourAchats { get; set; }

    public virtual DbSet<TraceBonRetourVente> TraceBonRetourVentes { get; set; }

    public virtual DbSet<TraceBonSortie> TraceBonSorties { get; set; }

    public virtual DbSet<TraceBonTransfert> TraceBonTransferts { get; set; }

    public virtual DbSet<TraceDetailReglementClient> TraceDetailReglementClients { get; set; }

    public virtual DbSet<TraceDetailReglementFournisseur> TraceDetailReglementFournisseurs { get; set; }

    public virtual DbSet<TraceDevisVente> TraceDevisVentes { get; set; }

    public virtual DbSet<TraceFactureAchat> TraceFactureAchats { get; set; }

    public virtual DbSet<TraceFactureExport> TraceFactureExports { get; set; }

    public virtual DbSet<TraceFactureVente> TraceFactureVentes { get; set; }

    public virtual DbSet<TraceInventaire> TraceInventaires { get; set; }

    public virtual DbSet<TraceMouvementCompte> TraceMouvementComptes { get; set; }

    public virtual DbSet<TracePreFacture> TracePreFactures { get; set; }

    public virtual DbSet<TraceReglementClient> TraceReglementClients { get; set; }

    public virtual DbSet<TraceReglementFournisseur> TraceReglementFournisseurs { get; set; }

    public virtual DbSet<Transfert> Transferts { get; set; }

    public virtual DbSet<Tva> Tvas { get; set; }

    public virtual DbSet<TvaavoirAchat> TvaavoirAchats { get; set; }

    public virtual DbSet<TvaavoirVente> TvaavoirVentes { get; set; }

    public virtual DbSet<TvabonCommandeAchat> TvabonCommandeAchats { get; set; }

    public virtual DbSet<TvabonCommandeVente> TvabonCommandeVentes { get; set; }

    public virtual DbSet<TvabonEntrer> TvabonEntrers { get; set; }

    public virtual DbSet<TvabonLivraisonAchat> TvabonLivraisonAchats { get; set; }

    public virtual DbSet<TvabonLivraisonVente> TvabonLivraisonVentes { get; set; }

    public virtual DbSet<TvabonRetourAchat> TvabonRetourAchats { get; set; }

    public virtual DbSet<TvabonRetourLivreur> TvabonRetourLivreurs { get; set; }

    public virtual DbSet<TvabonRetourVente> TvabonRetourVentes { get; set; }

    public virtual DbSet<TvabonSortie> TvabonSorties { get; set; }

    public virtual DbSet<TvabonSortieLivreur> TvabonSortieLivreurs { get; set; }

    public virtual DbSet<TvabonTransfert> TvabonTransferts { get; set; }

    public virtual DbSet<TvadevisVente> TvadevisVentes { get; set; }

    public virtual DbSet<TvafactureAchat> TvafactureAchats { get; set; }

    public virtual DbSet<TvafactureAchatDiver> TvafactureAchatDivers { get; set; }

    public virtual DbSet<TvafactureExport> TvafactureExports { get; set; }

    public virtual DbSet<TvafactureExportTnd> TvafactureExportTnds { get; set; }

    public virtual DbSet<TvafactureVente> TvafactureVentes { get; set; }

    public virtual DbSet<TvaficheIntervention> TvaficheInterventions { get; set; }

    public virtual DbSet<Tvaprefacture> Tvaprefactures { get; set; }

    public virtual DbSet<TypeArticle> TypeArticles { get; set; }

    public virtual DbSet<TypeContrat> TypeContrats { get; set; }

    public virtual DbSet<TypeDepense> TypeDepenses { get; set; }

    public virtual DbSet<TypeTransport> TypeTransports { get; set; }

    public virtual DbSet<TypeVente> TypeVentes { get; set; }

    public virtual DbSet<TypeVisite> TypeVisites { get; set; }

    public virtual DbSet<UniteArticle> UniteArticles { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    public virtual DbSet<ValidationDecaissement> ValidationDecaissements { get; set; }

    public virtual DbSet<Versement> Versements { get; set; }

    public virtual DbSet<VueArticle> VueArticles { get; set; }

    public virtual DbSet<VueAvanceFournisseur> VueAvanceFournisseurs { get; set; }

    public virtual DbSet<VueBonCommandeVente> VueBonCommandeVentes { get; set; }

    public virtual DbSet<VueBonLivaisonVente> VueBonLivaisonVentes { get; set; }

    public virtual DbSet<VueBonRetourVente> VueBonRetourVentes { get; set; }

    public virtual DbSet<VueControleAccee> VueControleAccees { get; set; }

    public virtual DbSet<VueDepence> VueDepences { get; set; }

    public virtual DbSet<VueDepotArticle> VueDepotArticles { get; set; }

    public virtual DbSet<VueDesCommutionRepresentant> VueDesCommutionRepresentants { get; set; }

    public virtual DbSet<VueDetailEntrerSortieArticle> VueDetailEntrerSortieArticles { get; set; }

    public virtual DbSet<VueDetailLettrage> VueDetailLettrages { get; set; }

    public virtual DbSet<VueDetailReglementClientFacturer> VueDetailReglementClientFacturers { get; set; }

    public virtual DbSet<VueDetailRemplacementClient> VueDetailRemplacementClients { get; set; }

    public virtual DbSet<VueEtatArticleBc> VueEtatArticleBcs { get; set; }

    public virtual DbSet<VueEtatArticleBl> VueEtatArticleBls { get; set; }

    public virtual DbSet<VueEtatArticleFacture> VueEtatArticleFactures { get; set; }

    public virtual DbSet<VueEtatArticleNonVendu> VueEtatArticleNonVendus { get; set; }

    public virtual DbSet<VueEtatArticleVendu> VueEtatArticleVendus { get; set; }

    public virtual DbSet<VueFactureBonLivraison> VueFactureBonLivraisons { get; set; }

    public virtual DbSet<VueFicheInterventionAvecService> VueFicheInterventionAvecServices { get; set; }

    public virtual DbSet<VueLigneAvoirAchat> VueLigneAvoirAchats { get; set; }

    public virtual DbSet<VueLigneAvoirVente> VueLigneAvoirVentes { get; set; }

    public virtual DbSet<VueLigneBonCommandeAchat> VueLigneBonCommandeAchats { get; set; }

    public virtual DbSet<VueLigneBonCommandeVente> VueLigneBonCommandeVentes { get; set; }

    public virtual DbSet<VueLigneBonEntrer> VueLigneBonEntrers { get; set; }

    public virtual DbSet<VueLigneBonLivraisonAchat> VueLigneBonLivraisonAchats { get; set; }

    public virtual DbSet<VueLigneBonLivraisonVente> VueLigneBonLivraisonVentes { get; set; }

    public virtual DbSet<VueLigneBonRetourAchat> VueLigneBonRetourAchats { get; set; }

    public virtual DbSet<VueLigneBonRetourVente> VueLigneBonRetourVentes { get; set; }

    public virtual DbSet<VueLigneBonSortie> VueLigneBonSorties { get; set; }

    public virtual DbSet<VueLigneBonTransfert> VueLigneBonTransferts { get; set; }

    public virtual DbSet<VueLigneBordereauEscompte> VueLigneBordereauEscomptes { get; set; }

    public virtual DbSet<VueLigneContratClient> VueLigneContratClients { get; set; }

    public virtual DbSet<VueLigneDemandePrix> VueLigneDemandePrixes { get; set; }

    public virtual DbSet<VueLigneDevisVente> VueLigneDevisVentes { get; set; }

    public virtual DbSet<VueLigneFactureAchat> VueLigneFactureAchats { get; set; }

    public virtual DbSet<VueLigneFactureAchatDiver> VueLigneFactureAchatDivers { get; set; }

    public virtual DbSet<VueLigneFactureExport> VueLigneFactureExports { get; set; }

    public virtual DbSet<VueLigneFactureExportTnd> VueLigneFactureExportTnds { get; set; }

    public virtual DbSet<VueLigneFactureVente> VueLigneFactureVentes { get; set; }

    public virtual DbSet<VueLigneFicheIntervention> VueLigneFicheInterventions { get; set; }

    public virtual DbSet<VueLigneInventaire> VueLigneInventaires { get; set; }

    public virtual DbSet<VueLignePreFacture> VueLignePreFactures { get; set; }

    public virtual DbSet<VueLignePrefacture1> VueLignePrefactures1 { get; set; }

    public virtual DbSet<VueLigneReglementClient> VueLigneReglementClients { get; set; }

    public virtual DbSet<VueListeAfacturer> VueListeAfacturers { get; set; }

    public virtual DbSet<VueListeArticle> VueListeArticles { get; set; }

    public virtual DbSet<VueListeArticleEnStockParDatePremierAchatEtDernierDateAchat> VueListeArticleEnStockParDatePremierAchatEtDernierDateAchats { get; set; }

    public virtual DbSet<VueListeArticleFournisseur> VueListeArticleFournisseurs { get; set; }

    public virtual DbSet<VueListeAvanceClient> VueListeAvanceClients { get; set; }

    public virtual DbSet<VueListeAvanceFournisseur> VueListeAvanceFournisseurs { get; set; }

    public virtual DbSet<VueListeAvoirAchat> VueListeAvoirAchats { get; set; }

    public virtual DbSet<VueListeAvoirVente> VueListeAvoirVentes { get; set; }

    public virtual DbSet<VueListeBonCommandeAchat> VueListeBonCommandeAchats { get; set; }

    public virtual DbSet<VueListeBonCommandeVente> VueListeBonCommandeVentes { get; set; }

    public virtual DbSet<VueListeBonEntrer> VueListeBonEntrers { get; set; }

    public virtual DbSet<VueListeBonLivraisonAchat> VueListeBonLivraisonAchats { get; set; }

    public virtual DbSet<VueListeBonLivraisonVente> VueListeBonLivraisonVentes { get; set; }

    public virtual DbSet<VueListeBonRetourAchat> VueListeBonRetourAchats { get; set; }

    public virtual DbSet<VueListeBonRetourLivreur> VueListeBonRetourLivreurs { get; set; }

    public virtual DbSet<VueListeBonRetourVente> VueListeBonRetourVentes { get; set; }

    public virtual DbSet<VueListeBonSortie> VueListeBonSorties { get; set; }

    public virtual DbSet<VueListeBonSortieLivreur> VueListeBonSortieLivreurs { get; set; }

    public virtual DbSet<VueListeBonTransfert> VueListeBonTransferts { get; set; }

    public virtual DbSet<VueListeBordereauVersementPourConsultation> VueListeBordereauVersementPourConsultations { get; set; }

    public virtual DbSet<VueListeCamion> VueListeCamions { get; set; }

    public virtual DbSet<VueListeClient> VueListeClients { get; set; }

    public virtual DbSet<VueListeClientPayerNonFacturer> VueListeClientPayerNonFacturers { get; set; }

    public virtual DbSet<VueListeCommution> VueListeCommutions { get; set; }

    public virtual DbSet<VueListeContratClient> VueListeContratClients { get; set; }

    public virtual DbSet<VueListeDemandePrix> VueListeDemandePrixes { get; set; }

    public virtual DbSet<VueListeDetailReglement> VueListeDetailReglements { get; set; }

    public virtual DbSet<VueListeDevisVente> VueListeDevisVentes { get; set; }

    public virtual DbSet<VueListeEncoursClient> VueListeEncoursClients { get; set; }

    public virtual DbSet<VueListeExportation> VueListeExportations { get; set; }

    public virtual DbSet<VueListeFactureAchat> VueListeFactureAchats { get; set; }

    public virtual DbSet<VueListeFactureAchatDiver> VueListeFactureAchatDivers { get; set; }

    public virtual DbSet<VueListeFactureExport> VueListeFactureExports { get; set; }

    public virtual DbSet<VueListeFactureExportTnd> VueListeFactureExportTnds { get; set; }

    public virtual DbSet<VueListeFactureVente> VueListeFactureVentes { get; set; }

    public virtual DbSet<VueListeFicheIntervention> VueListeFicheInterventions { get; set; }

    public virtual DbSet<VueListeFournisseurArticle> VueListeFournisseurArticles { get; set; }

    public virtual DbSet<VueListeIntervenantParFiche> VueListeIntervenantParFiches { get; set; }

    public virtual DbSet<VueListeInventaire> VueListeInventaires { get; set; }

    public virtual DbSet<VueListeLot> VueListeLots { get; set; }

    public virtual DbSet<VueListeMouvementClient> VueListeMouvementClients { get; set; }

    public virtual DbSet<VueListePieceAreglerPourChaqueClient> VueListePieceAreglerPourChaqueClients { get; set; }

    public virtual DbSet<VueListePrefacture> VueListePrefactures { get; set; }

    public virtual DbSet<VueListeReceptionMateriel> VueListeReceptionMateriels { get; set; }

    public virtual DbSet<VueListeReglementClient> VueListeReglementClients { get; set; }

    public virtual DbSet<VueListeReglementClientDetail> VueListeReglementClientDetails { get; set; }

    public virtual DbSet<VueListeReglementClientEnCour> VueListeReglementClientEnCours { get; set; }

    public virtual DbSet<VueListeReglementClientPayee> VueListeReglementClientPayees { get; set; }

    public virtual DbSet<VueListeReglementFournisseur> VueListeReglementFournisseurs { get; set; }

    public virtual DbSet<VueListeReglementFournisseurDetail> VueListeReglementFournisseurDetails { get; set; }

    public virtual DbSet<VueListeReglementFournisseurEnCour> VueListeReglementFournisseurEnCours { get; set; }

    public virtual DbSet<VueListeReglementFournisseurPayee> VueListeReglementFournisseurPayees { get; set; }

    public virtual DbSet<VueListeReglementParLivreur> VueListeReglementParLivreurs { get; set; }

    public virtual DbSet<VueListeRemplacementClient> VueListeRemplacementClients { get; set; }

    public virtual DbSet<VueListeRetenuFactureAchat> VueListeRetenuFactureAchats { get; set; }

    public virtual DbSet<VueListeRetenuFactureVente> VueListeRetenuFactureVentes { get; set; }

    public virtual DbSet<VueListeTousVenteMoinsReoursArticle> VueListeTousVenteMoinsReoursArticles { get; set; }

    public virtual DbSet<VueListeVenteArticle> VueListeVenteArticles { get; set; }

    public virtual DbSet<VueMouvementCompte> VueMouvementComptes { get; set; }

    public virtual DbSet<VueMouvementStock> VueMouvementStocks { get; set; }

    public virtual DbSet<VueObjectifParZone> VueObjectifParZones { get; set; }

    public virtual DbSet<VueOperationProgramme> VueOperationProgrammes { get; set; }

    public virtual DbSet<VuePieceClientAreglerFinal> VuePieceClientAreglerFinals { get; set; }

    public virtual DbSet<VuePieceNonPayerClient> VuePieceNonPayerClients { get; set; }

    public virtual DbSet<VuePieceNonPayerClientParDate> VuePieceNonPayerClientParDates { get; set; }

    public virtual DbSet<VuePieceValiserRecuperer> VuePieceValiserRecuperers { get; set; }

    public virtual DbSet<VueRapportValise> VueRapportValises { get; set; }

    public virtual DbSet<VueRechercheArticleQuantite> VueRechercheArticleQuantites { get; set; }

    public virtual DbSet<VueReglementNonCloture> VueReglementNonClotures { get; set; }

    public virtual DbSet<VueReglementNonImpayeEtNonRemplace> VueReglementNonImpayeEtNonRemplaces { get; set; }

    public virtual DbSet<VueSoldeClientfinal> VueSoldeClientfinals { get; set; }

    public virtual DbSet<VueStockGlobal> VueStockGlobals { get; set; }

    public virtual DbSet<VueStockLivreur> VueStockLivreurs { get; set; }

    public virtual DbSet<VueSuivieBonCommande> VueSuivieBonCommandes { get; set; }

    public virtual DbSet<VueSuivieClient> VueSuivieClients { get; set; }

    public virtual DbSet<VueSuivieClient2> VueSuivieClient2s { get; set; }

    public virtual DbSet<VueSuivieCommusionSudOptique> VueSuivieCommusionSudOptiques { get; set; }

    public virtual DbSet<VueSuivieFournisseur> VueSuivieFournisseurs { get; set; }

    public virtual DbSet<VueSuivieMouvementStock> VueSuivieMouvementStocks { get; set; }

    public virtual DbSet<VueTotalCreditClient> VueTotalCreditClients { get; set; }

    public virtual DbSet<VueTotalCreditClientFinal> VueTotalCreditClientFinals { get; set; }

    public virtual DbSet<VueTvafacturesVente> VueTvafacturesVentes { get; set; }

    public virtual DbSet<ZoneClient> ZoneClients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=192.168.1.200,1433;database=GrosOptiqueStandard;User ID=sa;Password=ideal2s;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aa>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("AA");

            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Marge).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixAchatTtc)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatTTC");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteTTC");
        });

        modelBuilder.Entity<AcodeBare>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("ACodeBare");

            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeBarre)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.CodeArticle).HasName("PK_Articles");

            entity.ToTable("Article");

            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeBarre)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeCalibre)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeCouleur)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeEtui)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeFournisseur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.CodeSexe)
                .HasMaxLength(1)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeSousFamille).HasMaxLength(17);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.CodeType).HasMaxLength(6);
            entity.Property(e => e.CodeUnite).HasMaxLength(6);
            entity.Property(e => e.CodeUniteVente)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DernierPrixAchatAvantCalculCout)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DernierPrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("DernierPrixAchatHT");
            entity.Property(e => e.DernierPrixDevise).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.DernierTauxRemise).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.ImageCodeBarre).HasColumnType("image");
            entity.Property(e => e.LiteTauxRemise).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Logo).HasColumnType("image");
            entity.Property(e => e.Marge).HasColumnType("decimal(9, 3)");
            entity.Property(e => e.Observation).HasMaxLength(500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteTTC");
            entity.Property(e => e.Reference)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ValeurUniteVente)
                .HasDefaultValueSql("((1))")
                .HasColumnType("numeric(18, 5)");
        });

        modelBuilder.Entity<ArticleCodeBarre>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("ArticleCodeBarre");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeBarre).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(250);
            entity.Property(e => e.ImageCodeBarre).HasColumnType("image");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("PrixVenteTTC");
        });

        modelBuilder.Entity<ArticleDefectueuseDansValise>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommande, e.CodeArticle, e.CodeDepot, e.NumeroOrdre });

            entity.ToTable("ArticleDefectueuseDansValise");

            entity.Property(e => e.NumeroBonCommande)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'bc_x')");
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.NumeroOrdre).HasDefaultValueSql("((1))");
            entity.Property(e => e.CodeCause)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleCause).HasMaxLength(300);
            entity.Property(e => e.Quantite).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<ArticleNumeroSerie>(entity =>
        {
            entity.HasKey(e => new { e.CodeArticle, e.NumeroSerie });

            entity.ToTable("ArticleNumeroSerie");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.NumeroSerie).HasMaxLength(60);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.NumeroAvoirAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroAvoirVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonEntrer)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonLivraisonAchat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonLivraisonVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonRetourAchat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonRetourVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonSortie)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroFactureAchat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroInventaire)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPieceAchat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPieceVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<ArticleParFournisseur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleParFournisseur");

            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
        });

        modelBuilder.Entity<ArticleTerminal>(entity =>
        {
            entity.HasKey(e => e.Numero);

            entity.ToTable("ArticleTerminal");

            entity.Property(e => e.Numero).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<Articlee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Articlee");

            entity.Property(e => e.CodeArticle).HasMaxLength(50);
            entity.Property(e => e.CodeBarre).HasMaxLength(50);
        });

        modelBuilder.Entity<Assurance>(entity =>
        {
            entity.HasKey(e => e.CodeAssurance).HasName("PK_Assurances");

            entity.ToTable("Assurance");

            entity.Property(e => e.CodeAssurance).HasMaxLength(16);
            entity.Property(e => e.Libelle).HasMaxLength(255);
        });

        modelBuilder.Entity<AvanceClient>(entity =>
        {
            entity.HasKey(e => e.NumeroAvanceClient);

            entity.ToTable("AvanceClient", tb =>
                {
                    tb.HasTrigger("TracAddAvanceClient");
                    tb.HasTrigger("TracDeleteAvanceClient");
                    tb.HasTrigger("TracUpdateAvanceClient");
                });

            entity.Property(e => e.NumeroAvanceClient).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.CodeRetenu)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateAvance)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.EtatAvance).HasMaxLength(10);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NetAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(50);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<AvanceFournisseur>(entity =>
        {
            entity.HasKey(e => e.NumeroAvanceFournisseur).HasName("PK_AvanceFournisseur_1");

            entity.ToTable("AvanceFournisseur", tb =>
                {
                    tb.HasTrigger("TracAddAvanceFournisseur");
                    tb.HasTrigger("TracDeleteAvanceFournisseur");
                    tb.HasTrigger("TracUpdateAvanceFournisseur");
                });

            entity.Property(e => e.NumeroAvanceFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.CodeRetenu)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateAvance)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.EtatAvance).HasMaxLength(10);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NetAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementFournisseur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(50);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<AvoirAchat>(entity =>
        {
            entity.HasKey(e => e.NumeroAvoirAchat).HasName("PK_FactureAvoirAchat");

            entity.ToTable("AvoirAchat");

            entity.Property(e => e.NumeroAvoirAchat).HasMaxLength(10);
            entity.Property(e => e.CodeDepot)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateAvoirAchat).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRefrenceFournisseur).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroExportation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.ReferenceFournisseur).HasMaxLength(20);
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<AvoirVente>(entity =>
        {
            entity.HasKey(e => e.NumeroAvoirVente).HasName("PK_FactureAvoirVente");

            entity.ToTable("AvoirVente");

            entity.Property(e => e.NumeroAvoirVente).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDepot)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateAvoirVente).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroExportation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<Banque>(entity =>
        {
            entity.HasKey(e => e.CodeBanque);

            entity.ToTable("Banque");

            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.Adresse)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodePostal)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Mail)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Pays)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Siege)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SiteWeb)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Ville)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<BanqueSociete>(entity =>
        {
            entity.HasKey(e => e.CodeBanque);

            entity.ToTable("BanqueSociete");

            entity.Property(e => e.CodeBanque).HasMaxLength(50);
            entity.Property(e => e.Libelle).HasMaxLength(150);
            entity.Property(e => e.MontantCommisionChéque).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.MontantCommisionTraiteDecaissement).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.MontantCommisionTraitePret).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.MontantCommisionVirement).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.MontantCommisionVirementDecaissement).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.RibBancaire)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Bic>(entity =>
        {
            entity.HasKey(e => e.CodeBic).HasName("PK_BICs");

            entity.ToTable("BIC");

            entity.Property(e => e.CodeBic)
                .HasMaxLength(16)
                .HasColumnName("CodeBIC");
            entity.Property(e => e.Libelle).HasMaxLength(255);
        });

        modelBuilder.Entity<BonCommandeAchat>(entity =>
        {
            entity.HasKey(e => e.NumeroBonCommandeAchat).HasName("PK_CommandesAchat");

            entity.ToTable("BonCommandeAchat");

            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateBonCommandeAchat).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DelaiLivraison)
                .HasMaxLength(100)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.ModalitePaiement)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Nref)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("NRef");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.VilleLivraison)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Vref)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')")
                .HasColumnName("VRef");
        });

        modelBuilder.Entity<BonCommandeVente>(entity =>
        {
            entity.HasKey(e => e.NumeroBonCommandeVente).HasName("PK_CommandeVente");

            entity.ToTable("BonCommandeVente");

            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeTypeVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'VENTE')");
            entity.Property(e => e.DateBonCommandeVente).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReferenceClient).HasColumnType("datetime");
            entity.Property(e => e.DelaiLivraison).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.ReferenceClient)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonEntrer>(entity =>
        {
            entity.HasKey(e => e.NumeroBonEntrer);

            entity.ToTable("BonEntrer");

            entity.Property(e => e.NumeroBonEntrer).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.DateBonEntrer).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonLivraisonAchat>(entity =>
        {
            entity.HasKey(e => e.NumeroBonLivraisonAchat);

            entity.ToTable("BonLivraisonAchat");

            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.Bldevise)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("BLDevise");
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateBonLivraisonAchat).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReferenceFournisseur).HasColumnType("datetime");
            entity.Property(e => e.Devise)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FraisTransport).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Nbimpression).HasColumnName("NBImpression");
            entity.Property(e => e.Nbvalise)
                .HasDefaultValueSql("((4))")
                .HasColumnName("NBValise");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroExportation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.ReferenceFournisseur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TauxDeChange)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonLivraisonVente>(entity =>
        {
            entity.HasKey(e => e.NumeroBonLivraisonVente);

            entity.ToTable("BonLivraisonVente");

            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.CodeCamion)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeTypeVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'VENTE')");
            entity.Property(e => e.DateBonLivraisonVente).HasColumnType("datetime");
            entity.Property(e => e.DateCommande)
                .HasDefaultValueSql("(((1)/(1))/(2017))")
                .HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateLivraison)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateValidation)
                .HasDefaultValueSql("(((1)/(1))/(2017))")
                .HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NomValideur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroExportation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.ObservationInterne).HasDefaultValueSql("('')");
            entity.Property(e => e.ReferenceBonCommande)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonRetourAchat>(entity =>
        {
            entity.HasKey(e => e.NumeroBonRetourAchat);

            entity.ToTable("BonRetourAchat");

            entity.Property(e => e.NumeroBonRetourAchat).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateBonRetourAchat).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonRetourLivreur>(entity =>
        {
            entity.HasKey(e => e.NumeroBonRetourLivreur);

            entity.ToTable("BonRetourLivreur");

            entity.Property(e => e.NumeroBonRetourLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeDepotLivreur).HasMaxLength(6);
            entity.Property(e => e.CodeDepotRetour).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CreditClient).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CreditLivreur).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.DateBonRetourLivreur).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DepenceFixe).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.DepenceLivreur).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.GolbalVente).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonSortieLivreur).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.ReboucementLivreur).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RecetteReel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RecouvementClient).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RecouvrementLivreur).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonRetourVente>(entity =>
        {
            entity.HasKey(e => e.NumeroBonRetourVente);

            entity.ToTable("BonRetourVente");

            entity.Property(e => e.NumeroBonRetourVente).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeTypeVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("(N'VENTE')");
            entity.Property(e => e.DateBonRetourVente).HasColumnType("datetime");
            entity.Property(e => e.DateCommande)
                .HasDefaultValueSql("(((1)/(1))/(2017))")
                .HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroAvoirVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonSortie>(entity =>
        {
            entity.HasKey(e => e.NumeroBonSortie);

            entity.ToTable("BonSortie");

            entity.Property(e => e.NumeroBonSortie).HasMaxLength(10);
            entity.Property(e => e.CodeClient)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.DateBonSortie).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonSortieLivreur>(entity =>
        {
            entity.HasKey(e => e.NumeroBonSortieLivreur);

            entity.ToTable("BonSortieLivreur");

            entity.Property(e => e.NumeroBonSortieLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeCamion).HasMaxLength(10);
            entity.Property(e => e.CodeClient)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeDepotDestignation).HasMaxLength(6);
            entity.Property(e => e.CodeFamille)
                .HasMaxLength(16)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeMarque)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateBonSortieLivreur).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetour).HasColumnType("datetime");
            entity.Property(e => e.DepotSource).HasMaxLength(6);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonTransfert>(entity =>
        {
            entity.HasKey(e => e.NumeroBonTransfert);

            entity.ToTable("BonTransfert");

            entity.Property(e => e.NumeroBonTransfert).HasMaxLength(10);
            entity.Property(e => e.CodeCamion)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeDepotDestination).HasMaxLength(6);
            entity.Property(e => e.CodeDepotSource).HasMaxLength(6);
            entity.Property(e => e.DateAnnulationConfirmation)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateBonTransfert).HasColumnType("datetime");
            entity.Property(e => e.DateConfirmation)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetour)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomAnnulationConfirmation)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NomConfirmation)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonCommandeVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<BonTransformation>(entity =>
        {
            entity.HasKey(e => e.NumeroBonTransformation);

            entity.ToTable("BonTransformation");

            entity.Property(e => e.NumeroBonTransformation).HasMaxLength(10);
            entity.Property(e => e.Bd).HasColumnName("BD");
            entity.Property(e => e.Bg).HasColumnName("BG");
            entity.Property(e => e.Chd).HasColumnName("CHD");
            entity.Property(e => e.Chg).HasColumnName("CHG");
            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.DateBonTransformation).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Vd).HasColumnName("VD");
            entity.Property(e => e.Vg).HasColumnName("VG");
        });

        modelBuilder.Entity<BordereauEscompte>(entity =>
        {
            entity.HasKey(e => e.NumeroBordereau);

            entity.ToTable("BordereauEscompte");

            entity.Property(e => e.NumeroBordereau).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(10);
            entity.Property(e => e.CodeCompte)
                .HasMaxLength(35)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeModeReglement)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateBordereau).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDebutEcheance).HasColumnType("datetime");
            entity.Property(e => e.DateDernierEcheance)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateFinEcheance).HasColumnType("datetime");
            entity.Property(e => e.DateValidation)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantBordereau).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(30);
            entity.Property(e => e.NumeroBancaire)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<BordereauVersement>(entity =>
        {
            entity.HasKey(e => e.NumeroBordereau);

            entity.ToTable("BordereauVersement");

            entity.Property(e => e.NumeroBordereau).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(10);
            entity.Property(e => e.CodeCompte)
                .HasMaxLength(35)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeModeReglement)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateBordereau).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDebutEcheance).HasColumnType("datetime");
            entity.Property(e => e.DateFinEcheance).HasColumnType("datetime");
            entity.Property(e => e.DateValidation)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantBordereau).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(30);
            entity.Property(e => e.NumeroBancaire)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Calibre>(entity =>
        {
            entity.HasKey(e => e.CodeCalibre);

            entity.ToTable("Calibre");

            entity.Property(e => e.CodeCalibre).HasMaxLength(10);
            entity.Property(e => e.Libelle).HasMaxLength(30);
        });

        modelBuilder.Entity<Camion>(entity =>
        {
            entity.HasKey(e => e.CodeCamion);

            entity.ToTable("Camion");

            entity.Property(e => e.CodeCamion).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.Libelle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Martricule).HasMaxLength(60);
            entity.Property(e => e.Observation).HasMaxLength(300);
        });

        modelBuilder.Entity<CauseAnnulationReservation>(entity =>
        {
            entity.HasKey(e => e.CodeCause);

            entity.ToTable("CauseAnnulationReservation");

            entity.Property(e => e.CodeCause).HasMaxLength(20);
            entity.Property(e => e.Libelle).HasMaxLength(50);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.CodeClient).HasName("PK_Clients");

            entity.ToTable("Client");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.Activite)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Adresse1)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Adresse2)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Assujetti)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Autorise)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CodeBanque)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeClientParent)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeFamille)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeForme)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeLivreur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodePostal1)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodePostal2)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeRaisonBlocageClient)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeZoneClient)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CompteComptable)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DateDebutAutorisation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateDebutExoneration).HasColumnType("datetime");
            entity.Property(e => e.DateDernierBl)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("DateDernierBL");
            entity.Property(e => e.DateFinExoneration).HasColumnType("datetime");
            entity.Property(e => e.Fax1)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Fax2)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Mail)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MatriculeFiscale)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NbreJourEngagementPaiement).HasDefaultValueSql("((90))");
            entity.Property(e => e.NumeroExoneration)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PayerTva)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("PayerTVA");
            entity.Property(e => e.Pays1)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Pays2)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(160)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RegimeReel)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.RegistreCommerce)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Responsable)
                .HasMaxLength(160)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RibBanquaire)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SeuilCredit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SeuilMaximum).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SeuilMinimum).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SiteWeb)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SolderFiche)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Tel1)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Tel2)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TimbreFiscal).HasDefaultValueSql("((1))");
            entity.Property(e => e.Ville1)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Ville2)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<ClientArticle>(entity =>
        {
            entity.HasKey(e => new { e.CodeArticle, e.CodeClient });

            entity.ToTable("ClientArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DernierPrixVente).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<ClientPassager>(entity =>
        {
            entity.HasKey(e => e.NumeroPiece);

            entity.ToTable("ClientPassager");

            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.NomClient).HasMaxLength(70);
        });

        modelBuilder.Entity<CommutionRepresentant>(entity =>
        {
            entity.HasKey(e => e.NumeroCommution);

            entity.ToTable("CommutionRepresentant");

            entity.Property(e => e.NumeroCommution)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeLivreur).HasMaxLength(50);
            entity.Property(e => e.DateCommution).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDebut).HasColumnType("datetime");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(1500);
        });

        modelBuilder.Entity<CompensationReglementClient>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementClient, e.NumeroPiece });

            entity.ToTable("CompensationReglementClient");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.MontantPieceTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantPieceTTC");
        });

        modelBuilder.Entity<CompensationReglementFournisseur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementFournisseur, e.NumeroPiece });

            entity.ToTable("CompensationReglementFournisseur");

            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.MontantPieceTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantPieceTTC");
        });

        modelBuilder.Entity<Compte>(entity =>
        {
            entity.HasKey(e => e.CodeCompte);

            entity.ToTable("Compte");

            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(50);
            entity.Property(e => e.NomBordereau)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Ribbancaire)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')")
                .HasColumnName("RIBBancaire");
        });

        modelBuilder.Entity<CompteurPiece>(entity =>
        {
            entity.HasKey(e => new { e.CodeSociete, e.NomPiecer }).HasName("PK_CompteurPiece_1");

            entity.ToTable("CompteurPiece");

            entity.Property(e => e.CodeSociete).HasMaxLength(6);
            entity.Property(e => e.NomPiecer)
                .HasMaxLength(25)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Annee)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Compteur)
                .HasMaxLength(5)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PrefixPiece)
                .HasMaxLength(2)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<ConditionReglement>(entity =>
        {
            entity.HasKey(e => e.CodeConditionReglement).HasName("PK_ConditionReglements");

            entity.ToTable("ConditionReglement");

            entity.Property(e => e.CodeConditionReglement).HasMaxLength(16);
            entity.Property(e => e.Libelle).HasMaxLength(200);
        });

        modelBuilder.Entity<ContratClient>(entity =>
        {
            entity.HasKey(e => e.NumeroContratClient);

            entity.ToTable("ContratClient");

            entity.Property(e => e.NumeroContratClient).HasMaxLength(10);
            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeTypeContrat).HasMaxLength(10);
            entity.Property(e => e.DateContratClient).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDebut).HasColumnType("datetime");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.DateFinProlongation)
                .HasDefaultValueSql("(((1)/(1))/(2030))")
                .HasColumnType("datetime");
            entity.Property(e => e.DatePremiereFactration).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.ModeFacturation).HasMaxLength(20);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(500);
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<CopieTable>(entity =>
        {
            entity.ToTable("CopieTable");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeArticle).HasMaxLength(50);
            entity.Property(e => e.Designation).HasMaxLength(600);
            entity.Property(e => e.PrixUnitaire).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<Couleur>(entity =>
        {
            entity.HasKey(e => e.CodeCouleur).HasName("PK_Coleurs");

            entity.ToTable("Couleur");

            entity.Property(e => e.CodeCouleur).HasMaxLength(10);
            entity.Property(e => e.Libelle).HasMaxLength(30);
        });

        modelBuilder.Entity<CourbeArticle>(entity =>
        {
            entity.HasKey(e => new { e.CodeArticle, e.Pointure });

            entity.ToTable("CourbeArticle");

            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Pointure).HasMaxLength(3);
            entity.Property(e => e.Courbe).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<DemandePrix>(entity =>
        {
            entity.HasKey(e => e.NumeroDemandePrix);

            entity.ToTable("DemandePrix");

            entity.Property(e => e.NumeroDemandePrix).HasMaxLength(10);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDemandePrix).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.Observation)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Depence>(entity =>
        {
            entity.HasKey(e => e.NumeroDepence);

            entity.ToTable("Depence");

            entity.Property(e => e.NumeroDepence).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDepence)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Libelle)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroBonCommandeAchat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(500);
        });

        modelBuilder.Entity<Depot>(entity =>
        {
            entity.HasKey(e => e.CodeDepot);

            entity.ToTable("Depot");

            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.Adresse)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Libelle)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroOrdre).HasDefaultValueSql("((1))");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Ville)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<DetailDepence>(entity =>
        {
            entity.HasKey(e => new { e.NumeroDepence, e.NumeroLigne });

            entity.ToTable("DetailDepence");

            entity.Property(e => e.NumeroDepence).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.CodeTypeDepense)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateVersement)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(150);
            entity.Property(e => e.Proteur)
                .HasMaxLength(70)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<DetailReglementClient>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementClient, e.CodeModeReglement, e.Reference });

            entity.ToTable("DetailReglementClient");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantCommution).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantLettre)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRestant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MontantVerser).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroBordereau)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroCommution)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroOperationRecu)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Porteur)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Rib)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("RIB");
            entity.Property(e => e.TauxCommution).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<DetailReglementEscompte>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementClient, e.CodeModeReglement, e.Reference });

            entity.ToTable("DetailReglementEscompte");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantLettre)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantVerser).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroBordereau)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Porteur)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Rib)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("RIB");
        });

        modelBuilder.Entity<DetailReglementFournisseur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementFournisseur, e.CodeModeReglement, e.Reference }).HasName("PK_DetailReglementfournisseur");

            entity.ToTable("DetailReglementFournisseur");

            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'CAISSE')");
            entity.Property(e => e.Echeance)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.MontantLettre)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroReglementClient)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroValidation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Porteur)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Rib)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("RIB");
        });

        modelBuilder.Entity<DetailReglementLivreur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonRetourLivreur, e.CodeModeReglement, e.Reference });

            entity.ToTable("DetailReglementLivreur");

            entity.Property(e => e.NumeroBonRetourLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantLettre)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
        });

        modelBuilder.Entity<DetailTransfert>(entity =>
        {
            entity.HasKey(e => new { e.NumeroTransfert, e.NumeroLigne });

            entity.ToTable("DetailTransfert");

            entity.Property(e => e.NumeroTransfert).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompteDestination).HasMaxLength(6);
            entity.Property(e => e.CodeCompteSource).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateVersement)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroOperation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(150);
            entity.Property(e => e.Proteur)
                .HasMaxLength(700)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<DetailVersement>(entity =>
        {
            entity.HasKey(e => new { e.NumeroVersement, e.NumeroLigne });

            entity.ToTable("DetailVersement");

            entity.Property(e => e.NumeroVersement).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateVersement)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(150);
            entity.Property(e => e.Proteur)
                .HasMaxLength(70)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<DevisVente>(entity =>
        {
            entity.HasKey(e => e.NumeroDevisVente).HasName("PK_Devis");

            entity.ToTable("DevisVente");

            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.AttentionDe)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.ConditionReglement)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ConditionVente)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDevisVente).HasColumnType("datetime");
            entity.Property(e => e.DelaiLivraison)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.ModeDeReglment)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.ValiditeOffre)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Vref)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<DroitAcce>(entity =>
        {
            entity.HasKey(e => new { e.NomMenu, e.NomUtilisateur });

            entity.Property(e => e.NomMenu).HasMaxLength(60);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
        });

        modelBuilder.Entity<EditionSuivieMouvementStock>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("EditionSuivieMouvementStock");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(8);
            entity.Property(e => e.CodeMarque).HasMaxLength(8);
            entity.Property(e => e.DateDernierVente).HasMaxLength(300);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(300);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("PrixVenteTTC");
            entity.Property(e => e.Qtachat)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTAchat");
            entity.Property(e => e.QtstockActuel)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTStockActuel");
            entity.Property(e => e.Qtvente)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTVente");
        });

        modelBuilder.Entity<EntetRemplacementClient>(entity =>
        {
            entity.HasKey(e => e.NumeroReMplacementClient).HasName("PK_RemplacementClients");

            entity.ToTable("EntetRemplacementClient");

            entity.Property(e => e.NumeroReMplacementClient).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Remise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeReglement).HasMaxLength(1);
        });

        modelBuilder.Entity<Etat>(entity =>
        {
            entity.HasKey(e => e.NumeroEtat);

            entity.ToTable("Etat");

            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Libelle).HasMaxLength(30);
        });

        modelBuilder.Entity<EtuiBonLivraisonVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonVente, e.CodeEtui });

            entity.ToTable("EtuiBonLivraisonVente");

            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.CodeEtui)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<ExonerationClient>(entity =>
        {
            entity.HasKey(e => new { e.CodeClient, e.NumeroExoneration });

            entity.ToTable("ExonerationClient");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.NumeroExoneration)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateDebutExoneration).HasColumnType("datetime");
            entity.Property(e => e.DateFinExoneration).HasColumnType("datetime");
        });

        modelBuilder.Entity<Exportation>(entity =>
        {
            entity.HasKey(e => e.NumeroExportation);

            entity.ToTable("Exportation");

            entity.Property(e => e.NumeroExportation).HasMaxLength(10);
            entity.Property(e => e.DateExportation).HasColumnType("datetime");
            entity.Property(e => e.MoisExportation)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(30);
        });

        modelBuilder.Entity<FactureAchat>(entity =>
        {
            entity.HasKey(e => e.NumeroFactureAchat).HasName("PK_FacturesAchat");

            entity.ToTable("FactureAchat");

            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.Assurence).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.AutreFrais).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CodeDepot)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CoutChange).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateFactureAchat).HasColumnType("datetime");
            entity.Property(e => e.DateReferenceFournisseur).HasColumnType("datetime");
            entity.Property(e => e.Douane).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.FraisTransit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Fret).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroExportation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.ReferenceFournisseur).HasMaxLength(20);
            entity.Property(e => e.TauxChange).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalAchatDevis).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFrais).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFraisTransportEnDevise).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.TransportLocal).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<FactureAchatDiver>(entity =>
        {
            entity.HasKey(e => e.NumeroAchatDiver);

            entity.Property(e => e.NumeroAchatDiver).HasMaxLength(10);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateAchatDiver).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReferenceFournisseur).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.ReferenceFournisseur).HasMaxLength(20);
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<FactureExport>(entity =>
        {
            entity.HasKey(e => e.NumeroFactureExport);

            entity.ToTable("FactureExport");

            entity.Property(e => e.NumeroFactureExport).HasMaxLength(10);
            entity.Property(e => e.AdresseFrontiere)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Assurance).HasMaxLength(500);
            entity.Property(e => e.AttentionDe)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.BaseAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Bic)
                .HasMaxLength(500)
                .HasColumnName("BIC");
            entity.Property(e => e.ChangementDevise)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Cl)
                .HasMaxLength(500)
                .HasColumnName("CL");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDevise).HasMaxLength(100);
            entity.Property(e => e.Commission).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ConditionReglement)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ConditionVente)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateFactureExport).HasColumnType("datetime");
            entity.Property(e => e.DelaiLivraison)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Deposit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Iban)
                .HasMaxLength(500)
                .HasColumnName("IBAN");
            entity.Property(e => e.Incoterme).HasMaxLength(255);
            entity.Property(e => e.ModeDeReglment)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Nbcolis)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NBColis");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NotreBanque).HasMaxLength(500);
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroOrdre)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPrefacture).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PoidsNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Remorque)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.Tracteur)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TypeTransport).HasMaxLength(500);
            entity.Property(e => e.ValiditeOffre)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Vehicule)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Vref)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<FactureExportTnd>(entity =>
        {
            entity.HasKey(e => e.NumeroFactureExportTnd);

            entity.ToTable("FactureExportTND");

            entity.Property(e => e.NumeroFactureExportTnd)
                .HasMaxLength(10)
                .HasColumnName("NumeroFactureExportTND");
            entity.Property(e => e.AdresseFrontiere)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Assurance).HasMaxLength(500);
            entity.Property(e => e.AttentionDe)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.BaseAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Bic)
                .HasMaxLength(500)
                .HasColumnName("BIC");
            entity.Property(e => e.ChangementDevise)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Cl)
                .HasMaxLength(500)
                .HasColumnName("CL");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDevise).HasMaxLength(100);
            entity.Property(e => e.Commission).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ConditionReglement)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ConditionVente)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateFactureExportTnd)
                .HasColumnType("datetime")
                .HasColumnName("DateFactureExportTND");
            entity.Property(e => e.DelaiLivraison)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Deposit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Iban)
                .HasMaxLength(500)
                .HasColumnName("IBAN");
            entity.Property(e => e.Incoterme).HasMaxLength(255);
            entity.Property(e => e.ModeDeReglment)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Nbcolis)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NBColis");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NotreBanque).HasMaxLength(500);
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroOrdre)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPrefacture).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PoidsNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.TypeTransport).HasMaxLength(500);
            entity.Property(e => e.ValiditeOffre)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Vref)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<FactureVente>(entity =>
        {
            entity.HasKey(e => e.NumeroFactureVente);

            entity.ToTable("FactureVente");

            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDepot)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Conditions)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateEcheance)
                .HasDefaultValueSql("(((4)/(8))/(2011))")
                .HasColumnType("datetime");
            entity.Property(e => e.DateFactureVente).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroExportation)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.ReglementFacture)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<FamilleArticle>(entity =>
        {
            entity.HasKey(e => e.CodeFamille).HasName("PK_FamillesArticles");

            entity.ToTable("FamilleArticle");

            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.Libelle).HasMaxLength(60);
        });

        modelBuilder.Entity<FamilleClient>(entity =>
        {
            entity.HasKey(e => e.CodeFamille).HasName("PK_FamillesClients");

            entity.ToTable("FamilleClient");

            entity.Property(e => e.CodeFamille).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(60);
        });

        modelBuilder.Entity<FamilleFournisseur>(entity =>
        {
            entity.HasKey(e => e.CodeFamille).HasName("PK_FamillesFournisseurs");

            entity.ToTable("FamilleFournisseur");

            entity.Property(e => e.CodeFamille).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(60);
        });

        modelBuilder.Entity<FicheIntervention>(entity =>
        {
            entity.HasKey(e => e.NumeroFicheIntervention).HasName("PK_FicheIntervantion");

            entity.ToTable("FicheIntervention");

            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
            entity.Property(e => e.Afacturer)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AFacturer");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeIntervenant).HasMaxLength(10);
            entity.Property(e => e.CodeNatureIntervention).HasMaxLength(10);
            entity.Property(e => e.ComposantUtiliser)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateFicheIntervention).HasColumnType("datetime");
            entity.Property(e => e.Duree).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibelleIntervantion)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPieceVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroReception)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.Reclamation)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<Fonction>(entity =>
        {
            entity.HasKey(e => e.CodeFonction);

            entity.ToTable("Fonction");

            entity.Property(e => e.CodeFonction).HasMaxLength(6);
            entity.Property(e => e.Libelle)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<FormeJuridique>(entity =>
        {
            entity.HasKey(e => e.CodeForme);

            entity.ToTable("FormeJuridique");

            entity.Property(e => e.CodeForme).HasMaxLength(6);
            entity.Property(e => e.Libelle)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Fournisseur>(entity =>
        {
            entity.HasKey(e => e.CodeFournisseur).HasName("PK_Fournisseurs");

            entity.ToTable("Fournisseur");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.Adresse1)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Adresse2)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Assujetti)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CodeBanque)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeFamille)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeForme)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodePostal1)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodePostal2)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CompteAchat)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CompteComptable)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateDebutExoneration).HasColumnType("datetime");
            entity.Property(e => e.DateFinExoneration).HasColumnType("datetime");
            entity.Property(e => e.Fax1)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Fax2)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Mail)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MatriculeFiscale)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroExoneration)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation)
                .HasMaxLength(1500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PayerTva)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("PayerTVA");
            entity.Property(e => e.Pays1).HasMaxLength(30);
            entity.Property(e => e.Pays2)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RegistreCommerce)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Responsable)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RibBanquaire)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SiteWeb)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SolderFiche)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Tel1)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Tel2)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TimbreFiscal)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Ville1)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Ville2)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<FournisseurArticle>(entity =>
        {
            entity.HasKey(e => new { e.CodeArticle, e.CodeFournisseur });

            entity.ToTable("FournisseurArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeArticleFournisseur)
                .HasMaxLength(60)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DernierPrixAchat).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<FournisseurPassager>(entity =>
        {
            entity.HasKey(e => e.NumeroPiece);

            entity.ToTable("FournisseurPassager");

            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.NomFournisseur).HasMaxLength(70);
        });

        modelBuilder.Entity<FraisPrixExport>(entity =>
        {
            entity.HasKey(e => new { e.NumeroPiece, e.CodeArticle });

            entity.ToTable("FraisPrixExport");

            entity.Property(e => e.NumeroPiece).HasMaxLength(30);
            entity.Property(e => e.CodeArticle).HasMaxLength(100);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.DesignationArticle).HasMaxLength(200);
            entity.Property(e => e.Frais3).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.FraisDouane).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.FraisTransport).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PoidsGlobal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixEnDevise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixGlobal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxEchange).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxFrais3).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxFraisDouane).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxFraisTransport).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<HistoriqueSoldeClient>(entity =>
        {
            entity.HasKey(e => e.CodeClient);

            entity.ToTable("HistoriqueSoldeClient");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateSolde).HasColumnType("datetime");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.SoldeCreditClient).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SoldeDebitClient).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<Iban>(entity =>
        {
            entity.HasKey(e => e.CodeIban).HasName("PK_IBANs");

            entity.ToTable("IBAN");

            entity.Property(e => e.CodeIban)
                .HasMaxLength(16)
                .HasColumnName("CodeIBAN");
            entity.Property(e => e.Libelle).HasMaxLength(255);
        });

        modelBuilder.Entity<ImageBonCommandevente>(entity =>
        {
            entity.HasKey(e => e.NumeroBonCommandeVente);

            entity.ToTable("ImageBonCommandevente");

            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(30);
            entity.Property(e => e.Image1).HasColumnType("image");
            entity.Property(e => e.Image2).HasColumnType("image");
        });

        modelBuilder.Entity<ImageClient>(entity =>
        {
            entity.HasKey(e => new { e.CodeClient, e.NomFichier });

            entity.ToTable("ImageClient");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.NomFichier).HasMaxLength(400);
            entity.Property(e => e.DateSaisie).HasColumnType("datetime");
            entity.Property(e => e.ImageSaisie).HasColumnType("image");
        });

        modelBuilder.Entity<ImageFicheIntervention>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFicheIntervention, e.NomFichier });

            entity.ToTable("ImageFicheIntervention");

            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
            entity.Property(e => e.NomFichier).HasMaxLength(400);
            entity.Property(e => e.DateSaisie).HasColumnType("datetime");
            entity.Property(e => e.ImageSaisie).HasColumnType("image");
        });

        modelBuilder.Entity<ImpayeClient>(entity =>
        {
            entity.HasKey(e => e.NumeroImpayeClient).HasName("PK_Impaye");

            entity.ToTable("ImpayeClient");

            entity.Property(e => e.NumeroImpayeClient).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateImpayeClient).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantImpayeClient).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TotaleRecu).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<ImpayeClientNonPayee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ImpayeClientNonPayee");

            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomClient).HasMaxLength(160);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Porteur).HasMaxLength(255);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.Restant).HasColumnType("numeric(19, 3)");
        });

        modelBuilder.Entity<ImpayeFournisseur>(entity =>
        {
            entity.HasKey(e => e.NumeroImpayeFournisseur);

            entity.ToTable("ImpayeFournisseur");

            entity.Property(e => e.NumeroImpayeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateImpayeFournisseur).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<ImportationComptable>(entity =>
        {
            entity.HasKey(e => new { e.NumeroImportation, e.NumeroPiece });

            entity.ToTable("ImportationComptable");

            entity.Property(e => e.NumeroImportation).HasMaxLength(150);
            entity.Property(e => e.NumeroPiece).HasMaxLength(50);
            entity.Property(e => e.DateImportation).HasMaxLength(25);
            entity.Property(e => e.NomPiece)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<ImpressionCreditSociete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImpressionCreditSociete");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Restant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalPayee).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<Incoterme>(entity =>
        {
            entity.HasKey(e => e.CodeIncoterme).HasName("PK_Incotermes");

            entity.ToTable("Incoterme");

            entity.Property(e => e.CodeIncoterme).HasMaxLength(16);
            entity.Property(e => e.Libelle).HasMaxLength(255);
        });

        modelBuilder.Entity<Intervenant>(entity =>
        {
            entity.HasKey(e => e.CodeIntervenant);

            entity.ToTable("Intervenant");

            entity.Property(e => e.CodeIntervenant).HasMaxLength(10);
            entity.Property(e => e.CodeService).HasMaxLength(10);
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
        });

        modelBuilder.Entity<IntervenantParFiche>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFicheIntervention, e.CodeIntervenant });

            entity.ToTable("IntervenantParFiche");

            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
            entity.Property(e => e.CodeIntervenant).HasMaxLength(10);
        });

        modelBuilder.Entity<Inventaire>(entity =>
        {
            entity.HasKey(e => e.NumeroInventaire);

            entity.ToTable("Inventaire");

            entity.Property(e => e.NumeroInventaire).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateInventaire).HasColumnType("datetime");
            entity.Property(e => e.DateValidation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureValidation).HasColumnType("datetime");
            entity.Property(e => e.NomCreateur).HasMaxLength(20);
            entity.Property(e => e.NomValidateur).HasMaxLength(20);
            entity.Property(e => e.Observation).HasMaxLength(500);
        });

        modelBuilder.Entity<LettragePourCommussion>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementClient, e.CodeModeReglement, e.Reference, e.NumeroPiece }).HasName("PK_LettragePourCommution");

            entity.ToTable("LettragePourCommussion");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantPieceTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantPieceTTC");
            entity.Property(e => e.MontantPrincipal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<LigneAvoirAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvoirAchat, e.CodeArticle, e.NumeroBonLivraisonAchat, e.NumeroOrdre }).HasName("PK_LignesFacturesAvoir");

            entity.ToTable("LigneAvoirAchat");

            entity.Property(e => e.NumeroAvoirAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.NumeroBonLivraisonAchat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneAvoirVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvoirVente, e.CodeArticle, e.NumeroBonLivraisonVente, e.NumeroOrdre }).HasName("PK_LignesFacturesAvoirVente");

            entity.ToTable("LigneAvoirVente");

            entity.Property(e => e.NumeroAvoirVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.NumeroBonLivraisonVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonCommandeAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeAchat, e.CodeArticle }).HasName("PK_LignesCommandesAchat");

            entity.ToTable("LigneBonCommandeAchat");

            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonCommandeVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeVente, e.CodeArticle, e.NumeroOrdre }).HasName("PK_LigneCommandeVente");

            entity.ToTable("LigneBonCommandeVente");

            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonCommandeVenteAndroid>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeVente, e.CodeArticle, e.NumeroOrdre });

            entity.ToTable("LigneBonCommandeVenteAndroid");

            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonEntrer>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonEntrer, e.CodeArticle }).HasName("PK_LigneBonEntrer_1");

            entity.ToTable("LigneBonEntrer");

            entity.Property(e => e.NumeroBonEntrer).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonLivraisonAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonAchat, e.CodeArticle }).HasName("PK_LignesBonLivraisonAchat");

            entity.ToTable("LigneBonLivraisonAchat");

            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PuenDevise)
                .HasDefaultValueSql("((1))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PUEnDevise");
            entity.Property(e => e.Qtimprimer)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("QTImprimer");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonLivraisonVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonVente, e.CodeArticle, e.NumeroOrdre }).HasName("PK_LignesBonLivraisonVente");

            entity.ToTable("LigneBonLivraisonVente");

            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonCommandeVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBonRetourLivreur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixUniteTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("PrixUniteTTC");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonRetourAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonRetourAchat, e.CodeArticle });

            entity.ToTable("LigneBonRetourAchat");

            entity.Property(e => e.NumeroBonRetourAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonRetourLivreur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonRetourLivreur, e.CodeArticle });

            entity.ToTable("LigneBonRetourLivreur");

            entity.Property(e => e.NumeroBonRetourLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteRetour).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteSortie).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonRetourVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonRetourVente, e.CodeArticle, e.NumeroOrdre });

            entity.ToTable("LigneBonRetourVente");

            entity.Property(e => e.NumeroBonRetourVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonSortie>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonSortie, e.CodeArticle }).HasName("PK_LigneBonSortie_1");

            entity.ToTable("LigneBonSortie");

            entity.Property(e => e.NumeroBonSortie).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonSortieLivreur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonSortieLivreur, e.CodeArticle }).HasName("PK_LigneBonSortieLivreur_1");

            entity.ToTable("LigneBonSortieLivreur");

            entity.Property(e => e.NumeroBonSortieLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DateMaj)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroMaj).HasDefaultValueSql("((1))");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixUniteTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("PrixUniteTTC");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonTransfert>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonTransfert, e.CodeArticle }).HasName("PK_LigneBonTransfert_1");

            entity.ToTable("LigneBonTransfert");

            entity.Property(e => e.NumeroBonTransfert).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneBonTransformation>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonTransformation, e.CodeArticle });

            entity.ToTable("LigneBonTransformation");

            entity.Property(e => e.NumeroBonTransformation).HasMaxLength(10);
            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<LigneBordereauEscompte>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBordereau, e.NumeroReglementClient, e.CodeModeReglement, e.Reference });

            entity.ToTable("LigneBordereauEscompte");

            entity.Property(e => e.NumeroBordereau).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(20);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(20);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRetenu).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NumeroFactureVente)
                .HasMaxLength(25)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Ordre).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<LigneBordereauVersement>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBordereau, e.NumeroReglementClient, e.CodeModeReglement, e.Reference });

            entity.ToTable("LigneBordereauVersement");

            entity.Property(e => e.NumeroBordereau).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(20);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(20);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Ordre).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<LigneCommutionRepresentant>(entity =>
        {
            entity.ToTable("LigneCommutionRepresentant");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodeLivreur).HasMaxLength(50);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.MontantCommution).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroCommution)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TauxCommution).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<LigneContratClient>(entity =>
        {
            entity.HasKey(e => new { e.NumeroContratClient, e.NumeroQuittance });

            entity.ToTable("LigneContratClient");

            entity.Property(e => e.NumeroContratClient).HasMaxLength(10);
            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateDebut).HasColumnType("datetime");
            entity.Property(e => e.DateFacturation).HasMaxLength(10);
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.DateQuittance).HasColumnType("datetime");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<LigneDemandePrix>(entity =>
        {
            entity.HasKey(e => new { e.NumeroDemandePrix, e.CodeArticle }).HasName("PK_LigneDemandePrix_1");

            entity.ToTable("LigneDemandePrix");

            entity.Property(e => e.NumeroDemandePrix).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle).HasMaxLength(200);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<LigneDevisVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroDevisVente, e.CodeArticle });

            entity.ToTable("LigneDevisVente");

            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(4000);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneExportation>(entity =>
        {
            entity.HasKey(e => new { e.NumeroExportation, e.NumeroPiece });

            entity.ToTable("LigneExportation");

            entity.Property(e => e.NumeroExportation).HasMaxLength(10);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<LigneFactureAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureAchat, e.CodeArticle, e.NumeroBonLivraisonAchat, e.NumeroOrdre }).HasName("PK_LignesFacturesAchat");

            entity.ToTable("LigneFactureAchat");

            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.NumeroBonLivraisonAchat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixAchatHtchange)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHTChange");
            entity.Property(e => e.PrixAchatHtdevise)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHTDevise");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneFactureAchatDiver>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAchatDiver, e.NumeroOrdre });

            entity.Property(e => e.NumeroAchatDiver).HasMaxLength(10);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneFactureExport>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureExport, e.CodeArticle });

            entity.ToTable("LigneFactureExport");

            entity.Property(e => e.NumeroFactureExport).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Cat)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PoidsNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pointure)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PrePack)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneFactureExportTnd>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureExportTnd, e.CodeArticle });

            entity.ToTable("LigneFactureExportTND");

            entity.Property(e => e.NumeroFactureExportTnd)
                .HasMaxLength(10)
                .HasColumnName("NumeroFactureExportTND");
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Cat)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PoidsNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pointure)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PrePack)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneFactureVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureVente, e.CodeArticle, e.NumeroBonLivraisonVente, e.NumeroOrdre }).HasName("PK_LigneFactureVente_1");

            entity.ToTable("LigneFactureVente");

            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.NumeroBonLivraisonVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneFicheIntervention>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFicheIntervention, e.CodeArticle, e.NumeroOrdre }).HasName("PK_LigneFicheIntervention_1");

            entity.ToTable("LigneFicheIntervention");

            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneInventaire>(entity =>
        {
            entity.HasKey(e => new { e.NumeroInventaire, e.CodeArticle });

            entity.ToTable("LigneInventaire");

            entity.Property(e => e.NumeroInventaire).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.AncienneQuantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NouvelleQuantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Observation).HasMaxLength(500);
            entity.Property(e => e.PrixInventaire).HasColumnType("numeric(18, 5)");
        });

        modelBuilder.Entity<LigneObjectifRepresentantParQuantite>(entity =>
        {
            entity.HasKey(e => new { e.NumeroObjectif, e.NumeroOrdre });

            entity.ToTable("LigneObjectifRepresentantParQuantite");
        });

        modelBuilder.Entity<LigneObjectifSemaine>(entity =>
        {
            entity.HasKey(e => new { e.NumeroObjectifSemaine, e.CodeMarque });

            entity.ToTable("LigneObjectifSemaine");

            entity.Property(e => e.NumeroObjectifSemaine).HasMaxLength(10);
            entity.Property(e => e.CodeMarque).HasMaxLength(30);
            entity.Property(e => e.DesignationMarque).HasMaxLength(200);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<LignePreFacture>(entity =>
        {
            entity.HasKey(e => new { e.NumeroPreFacture, e.CodeArticle });

            entity.ToTable("LignePreFacture");

            entity.Property(e => e.NumeroPreFacture).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Cat)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MontantAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PoidsNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pointure)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PrePack)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<LigneReglementClient>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementClient, e.NumeroPiece }).HasName("PK_LigneReglement");

            entity.ToTable("LigneReglementClient");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.MontantPieceTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantPieceTTC");
            entity.Property(e => e.Observation).HasMaxLength(50);
            entity.Property(e => e.PieceDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalPayee).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRestant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.TypePiece)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<LigneReglementFournisseur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementFournisseur, e.NumeroPiece });

            entity.ToTable("LigneReglementFournisseur");

            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.MontantPieceTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantPieceTTC");
            entity.Property(e => e.Observation).HasMaxLength(50);
            entity.Property(e => e.TotalPayee).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRestant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<LigneRetenuFactureAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroRetenu, e.NumeroFactureAchat, e.CodeRetenu }).HasName("PK_LigneRetenuFactureAchat_1");

            entity.ToTable("LigneRetenuFactureAchat");

            entity.Property(e => e.NumeroRetenu).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.CodeRetenu).HasMaxLength(6);
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<LigneRetenuFactureVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroRetenu, e.NumeroFactureVente, e.CodeRetenu });

            entity.ToTable("LigneRetenuFactureVente");

            entity.Property(e => e.NumeroRetenu).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.CodeRetenu).HasMaxLength(6);
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<LigneValidationBonLivraisonVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonVente, e.CodeArticle });

            entity.ToTable("LigneValidationBonLivraisonVente");

            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<LigneValidationDecaissement>(entity =>
        {
            entity.HasKey(e => new { e.NumeroValidation, e.NumeroReglementFournisseur, e.CodeModeReglement, e.Reference });

            entity.ToTable("LigneValidationDecaissement");

            entity.Property(e => e.NumeroValidation).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(20);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(20);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.DateValidationPiece)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Ordre).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<ListeArticleStockZeroEtdemanderParClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeArticleStockZeroETDemanderParClient");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.Libelle)
                .HasMaxLength(60)
                .HasColumnName("libelle");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(37, 8)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(33, 11)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(32, 11)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.Observation)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.QteRestante).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<ListeBlBr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeBL_BR");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NumeroBl)
                .HasMaxLength(10)
                .HasColumnName("NumeroBL");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
        });

        modelBuilder.Entity<Livreur>(entity =>
        {
            entity.HasKey(e => e.CodeLivreur);

            entity.ToTable("Livreur");

            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.Actif)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Adresse)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Assistant).HasMaxLength(200);
            entity.Property(e => e.Cin)
                .HasMaxLength(20)
                .HasColumnName("CIN");
            entity.Property(e => e.Cinassistant)
                .HasMaxLength(20)
                .HasColumnName("CINAssistant");
            entity.Property(e => e.CodeBanque)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeCamion)
                .HasMaxLength(3)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CodeCompte)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'CAISSE')");
            entity.Property(e => e.CodeDepot)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodePostal)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.Observation).HasMaxLength(300);
            entity.Property(e => e.Pays)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RibBanquaire)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TauxCommission).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Tel1).HasMaxLength(30);
            entity.Property(e => e.Tel2).HasMaxLength(30);
            entity.Property(e => e.Ville)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Lot>(entity =>
        {
            entity.HasKey(e => e.NumeroLot);

            entity.ToTable("Lot");

            entity.Property(e => e.NumeroLot).HasMaxLength(60);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<MarqueArticle>(entity =>
        {
            entity.HasKey(e => e.CodeMarque).HasName("PK_Marques");

            entity.ToTable("MarqueArticle");

            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(60);
        });

        modelBuilder.Entity<MenuControle>(entity =>
        {
            entity.HasKey(e => e.NomMenu);

            entity.ToTable("MenuControle");

            entity.Property(e => e.NomMenu).HasMaxLength(60);
            entity.Property(e => e.Libelle).HasMaxLength(60);
            entity.Property(e => e.NomMenuParent).HasMaxLength(60);
        });

        modelBuilder.Entity<ModeReglement>(entity =>
        {
            entity.HasKey(e => e.CodeModeReglement);

            entity.ToTable("ModeReglement");

            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(60);
        });

        modelBuilder.Entity<MontureAtransformerEnSav>(entity =>
        {
            entity.HasKey(e => e.CodeMonture);

            entity.ToTable("MontureAtransformerEnSAV");

            entity.Property(e => e.CodeMonture).HasMaxLength(50);
        });

        modelBuilder.Entity<MouvementCompte>(entity =>
        {
            entity.HasKey(e => e.NumeroMouvement);

            entity.ToTable("MouvementCompte");

            entity.Property(e => e.NumeroMouvement).HasMaxLength(10);
            entity.Property(e => e.CodeBanque)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateMouvement)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Libelle)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(500);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TypeMouvement).HasMaxLength(1);
        });

        modelBuilder.Entity<NatureIntervention>(entity =>
        {
            entity.HasKey(e => e.CodeNatureIntervention);

            entity.ToTable("NatureIntervention");

            entity.Property(e => e.CodeNatureIntervention).HasMaxLength(10);
            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Libelle).HasMaxLength(100);
        });

        modelBuilder.Entity<NotreBanque>(entity =>
        {
            entity.HasKey(e => e.CodeNotreBanque).HasName("PK_NotreBanques");

            entity.ToTable("NotreBanque");

            entity.Property(e => e.CodeNotreBanque).HasMaxLength(16);
            entity.Property(e => e.Libelle).HasMaxLength(255);
        });

        modelBuilder.Entity<ObjectifRepresentantParQuantite>(entity =>
        {
            entity.HasKey(e => e.NumeroObjectif);

            entity.ToTable("ObjectifRepresentantParQuantite");

            entity.Property(e => e.NumeroObjectif).ValueGeneratedNever();
            entity.Property(e => e.AcheverLe).HasMaxLength(50);
            entity.Property(e => e.AcheverPar).HasMaxLength(50);
            entity.Property(e => e.CodeLivreur).HasMaxLength(50);
            entity.Property(e => e.CodeMarque).HasMaxLength(10);
            entity.Property(e => e.HeureCreation).HasMaxLength(50);
            entity.Property(e => e.NonUtilisateur).HasMaxLength(50);
            entity.Property(e => e.PeriodeAu).HasMaxLength(50);
            entity.Property(e => e.PeriodeDu).HasMaxLength(50);
        });

        modelBuilder.Entity<ObjectifSemaine>(entity =>
        {
            entity.HasKey(e => e.NumeroObjectifSemaine);

            entity.ToTable("ObjectifSemaine");

            entity.Property(e => e.NumeroObjectifSemaine).HasMaxLength(10);
            entity.Property(e => e.CodeMoisAnnee).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDebut).HasColumnType("datetime");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.DateSaisie).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.Observation).HasMaxLength(1500);
        });

        modelBuilder.Entity<ObjectifparZone>(entity =>
        {
            entity.HasKey(e => new { e.Annnee, e.Mois, e.CodeSemaine, e.CodeLivreur });

            entity.ToTable("ObjectifparZone");

            entity.Property(e => e.CodeSemaine).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(50);
            entity.Property(e => e.Quantite).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<OldRetenuFactureAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureAchat, e.CodeRetenu }).HasName("PK_RetenuFactureAchat");

            entity.ToTable("oldRetenuFactureAchat");

            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.CodeRetenu).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetenuAchat).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<OldRetenuFactureVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureVente, e.CodeRetenu }).HasName("PK_RetenuFactureVente");

            entity.ToTable("oldRetenuFactureVente");

            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.CodeRetenu).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetenuVente).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<OperationTresorerie>(entity =>
        {
            entity.HasKey(e => e.NumeroOperation);

            entity.ToTable("OperationTresorerie");

            entity.Property(e => e.NumeroOperation).HasMaxLength(10);
            entity.Property(e => e.CodeBanque)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateOperation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Libelle).HasMaxLength(150);
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(30);
            entity.Property(e => e.NumeroBordereau)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TypeOperation).HasMaxLength(5);
        });

        modelBuilder.Entity<OrderDepotDemande>(entity =>
        {
            entity.HasKey(e => new { e.CodeDepotDemandeur, e.CodeDepotDemandant, e.Ordre });

            entity.ToTable("OrderDepotDemande");

            entity.Property(e => e.CodeDepotDemandeur).HasMaxLength(10);
            entity.Property(e => e.CodeDepotDemandant).HasMaxLength(10);
            entity.Property(e => e.Ordre).HasColumnName("ordre");
        });

        modelBuilder.Entity<ParametreDiver>(entity =>
        {
            entity.HasKey(e => e.CodeSociete).HasName("PK_ParametresDivers");

            entity.ToTable("ParametreDiver");

            entity.Property(e => e.CodeSociete).HasMaxLength(6);
            entity.Property(e => e.Assujetti)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ChoixUniteAv).HasColumnName("ChoixUniteAV");
            entity.Property(e => e.CodeArticleAvoir)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeClientPassager).HasMaxLength(10);
            entity.Property(e => e.CodeCompte)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeFournisseurPassager).HasMaxLength(10);
            entity.Property(e => e.DateDebutExercice).HasColumnType("datetime");
            entity.Property(e => e.DateFinExercice).HasColumnType("datetime");
            entity.Property(e => e.DepotAchat).HasMaxLength(6);
            entity.Property(e => e.DepotVente).HasMaxLength(6);
            entity.Property(e => e.EngagementPaiementParClient).HasColumnName("engagementPaiementParClient");
            entity.Property(e => e.MargePerte).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.MargeProfit).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.ModeCalculPrix)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'DPA')");
            entity.Property(e => e.ModeGestionStock)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'FIFO')");
            entity.Property(e => e.MotPasseAdministrateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MotPasseModification)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.MotPasseSuppression)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NombreDecimalAchat)
                .HasDefaultValueSql("((5))")
                .HasColumnType("numeric(9, 0)");
            entity.Property(e => e.NombreDecimalVente)
                .HasDefaultValueSql("((5))")
                .HasColumnType("numeric(9, 0)");
            entity.Property(e => e.NombreJoursBlocageClientApresDerniereDateBl).HasColumnName("NombreJoursBlocageClientApresDerniereDateBL");
            entity.Property(e => e.TauxFodec).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxInteret).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxMajoration).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.ValeurStock)
                .HasMaxLength(6)
                .HasDefaultValueSql("(N'V')");
        });

        modelBuilder.Entity<PreFacture>(entity =>
        {
            entity.HasKey(e => e.NumeroPrefacture).HasName("PK_PreDevis");

            entity.ToTable("PreFacture");

            entity.Property(e => e.NumeroPrefacture).HasMaxLength(10);
            entity.Property(e => e.Assurance).HasMaxLength(500);
            entity.Property(e => e.AttentionDe)
                .HasMaxLength(80)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.BaseAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Bic)
                .HasMaxLength(500)
                .HasColumnName("BIC");
            entity.Property(e => e.ChangementDevise)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Cl)
                .HasMaxLength(500)
                .HasColumnName("CL");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDevise).HasMaxLength(100);
            entity.Property(e => e.Commission).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ConditionReglement)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ConditionVente)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DatePrefacture).HasColumnType("datetime");
            entity.Property(e => e.DelaiLivraison)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Deposit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Iban)
                .HasMaxLength(500)
                .HasColumnName("IBAN");
            entity.Property(e => e.Incoterme).HasMaxLength(255);
            entity.Property(e => e.ModeDeReglment)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Nbcolis)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NBColis");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NotreBanque).HasMaxLength(500);
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(3)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroFactureVente)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroOrdre)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PoidsNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.TypeTransport).HasMaxLength(500);
            entity.Property(e => e.ValiditeOffre)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Vref)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Preference>(entity =>
        {
            entity.HasKey(e => new { e.NomUtilisateur, e.NomGrid });

            entity.ToTable("Preference");

            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NomGrid).HasMaxLength(100);
        });

        modelBuilder.Entity<Presentation>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("PRESENTATION");

            entity.Property(e => e.CodeArticle)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<Qt27>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("QT27");

            entity.Property(e => e.CodeArticle).HasMaxLength(50);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<QuantiteSav05052023>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("QuantiteSAV05052023");

            entity.Property(e => e.CodeArticle).HasMaxLength(50);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<RaisonBlocageClient>(entity =>
        {
            entity.HasKey(e => e.CodeRaison).HasName("PK__RaisonBl__B4C34F247974A087");

            entity.ToTable("RaisonBlocageClient");

            entity.Property(e => e.CodeRaison)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')")
                .HasColumnName("codeRaison");
            entity.Property(e => e.Libelle)
                .HasMaxLength(50)
                .HasColumnName("libelle");
        });

        modelBuilder.Entity<RapportSuivie>(entity =>
        {
            entity.HasKey(e => e.NumeroRapportSuivie);

            entity.ToTable("RapportSuivie");

            entity.Property(e => e.NumeroRapportSuivie).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(30);
            entity.Property(e => e.CodeLivreur).HasMaxLength(30);
            entity.Property(e => e.CodeTypeVisite)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateRapportSuivie).HasColumnType("datetime");
            entity.Property(e => e.Observation).HasMaxLength(1000);
        });

        modelBuilder.Entity<ReceptionMateriel>(entity =>
        {
            entity.HasKey(e => e.NumeroReception);

            entity.ToTable("ReceptionMateriel");

            entity.Property(e => e.NumeroReception).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(30);
            entity.Property(e => e.CodeFournisseur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateEnvoie)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateReception).HasColumnType("datetime");
            entity.Property(e => e.DateRetour)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibellePanne).HasMaxLength(1500);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(10);
            entity.Property(e => e.Observation)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Piece)
                .HasMaxLength(1000)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<RegionClient>(entity =>
        {
            entity.HasKey(e => e.CodeRegionClient).HasName("PK_Region");

            entity.ToTable("RegionClient");

            entity.Property(e => e.CodeRegionClient).HasMaxLength(10);
            entity.Property(e => e.Libelle).HasMaxLength(150);
        });

        modelBuilder.Entity<ReglementClient>(entity =>
        {
            entity.HasKey(e => e.NumeroReglementClient).HasName("PK_Reglement");

            entity.ToTable("ReglementClient");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Remise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeReglement).HasMaxLength(1);
        });

        modelBuilder.Entity<ReglementEscompte>(entity =>
        {
            entity.HasKey(e => e.NumeroReglementClient);

            entity.ToTable("ReglementEscompte");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroBordereau).HasMaxLength(10);
            entity.Property(e => e.Observation)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TotalCommussion).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeReglement).HasMaxLength(1);
        });

        modelBuilder.Entity<ReglementFournisseur>(entity =>
        {
            entity.HasKey(e => e.NumeroReglementFournisseur);

            entity.ToTable("ReglementFournisseur");

            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Observation)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TotalAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeReglement).HasMaxLength(1);
        });

        modelBuilder.Entity<ReglementTemporaire>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementClient, e.CodeModeReglement, e.Reference });

            entity.ToTable("ReglementTemporaire");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Porteur)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Rib)
                .HasMaxLength(255)
                .HasDefaultValueSql("('')")
                .HasColumnName("RIB");
        });

        modelBuilder.Entity<RemplacementClient>(entity =>
        {
            entity.HasKey(e => new { e.NumeroRemplacementClient, e.CodeModeReglement, e.Reference });

            entity.ToTable("RemplacementClient");

            entity.Property(e => e.NumeroRemplacementClient).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRemplacementClient).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<RemplacementFournisseur>(entity =>
        {
            entity.HasKey(e => e.NumeroRemplacementFournisseur);

            entity.ToTable("RemplacementFournisseur");

            entity.Property(e => e.NumeroRemplacementFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRemplacementFournisseur).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<RemplacementPiece>(entity =>
        {
            entity.HasKey(e => e.NumeroRemplacementPiece);

            entity.ToTable("RemplacementPiece");

            entity.Property(e => e.NumeroRemplacementPiece).HasMaxLength(10);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRemplacementPiece).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRemplacementPiece).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<RendezVou>(entity =>
        {
            entity.HasKey(e => e.NumeroRdv);

            entity.Property(e => e.NumeroRdv)
                .HasMaxLength(30)
                .HasColumnName("NumeroRDV");
            entity.Property(e => e.CodeClient).HasMaxLength(30);
            entity.Property(e => e.CodeLivreur).HasMaxLength(30);
            entity.Property(e => e.CodeTypeVisite).HasMaxLength(30);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRdv)
                .HasColumnType("datetime")
                .HasColumnName("DateRDV");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Observation).HasMaxLength(500);
        });

        modelBuilder.Entity<ReservationArticleDansDepot>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeVente, e.CodeArticle, e.CodeDepotDemandant });

            entity.ToTable("ReservationArticleDansDepot");

            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeDepotDemandant).HasMaxLength(6);
            entity.Property(e => e.CodeDepotDemendeur).HasMaxLength(6);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.Quantite).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Telephone).HasColumnName("telephone");
        });

        modelBuilder.Entity<RetenuFactureAchat>(entity =>
        {
            entity.HasKey(e => e.NumeroRetenu).HasName("PK_RetenuFactureAchat_1");

            entity.ToTable("RetenuFactureAchat");

            entity.Property(e => e.NumeroRetenu).HasMaxLength(10);
            entity.Property(e => e.CodeFournisseur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetenuAchat).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<RetenuFactureVente>(entity =>
        {
            entity.HasKey(e => e.NumeroRetenu).HasName("PK_RetenuFactureVente_1");

            entity.ToTable("RetenuFactureVente");

            entity.Property(e => e.NumeroRetenu).HasMaxLength(10);
            entity.Property(e => e.CodeClient)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetenuVente).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<RetenuReglementClient>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementClient, e.CodeRetenu }).HasName("PK_RetenuReglement");

            entity.ToTable("RetenuReglementClient");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.CodeRetenu).HasMaxLength(6);
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<RetenuReglementFournisseur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementFournisseur, e.CodeRetenu });

            entity.ToTable("RetenuReglementFournisseur");

            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeRetenu).HasMaxLength(6);
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<RetenuSource>(entity =>
        {
            entity.HasKey(e => e.CodeRetenu);

            entity.ToTable("RetenuSource");

            entity.Property(e => e.CodeRetenu).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(100);
            entity.Property(e => e.TauxRetenu).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TypeRetenu)
                .HasMaxLength(3)
                .HasDefaultValueSql("(N'TTC')");
        });

        modelBuilder.Entity<RetourReglement>(entity =>
        {
            entity.HasKey(e => e.NumeroRetourReglement);

            entity.ToTable("RetourReglement");

            entity.Property(e => e.NumeroRetourReglement).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetourReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantRetourReglement).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPiece).HasMaxLength(30);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<SaisieFicheClient>(entity =>
        {
            entity.HasKey(e => e.NumeroSaisie);

            entity.ToTable("SaisieFicheClient");

            entity.Property(e => e.NumeroSaisie).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateOperation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Libelle).HasMaxLength(100);
            entity.Property(e => e.Montant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MontantNoir).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantReel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.TypeOperation).HasMaxLength(1);
        });

        modelBuilder.Entity<Semaine>(entity =>
        {
            entity.HasKey(e => new { e.Annnee, e.Mois, e.CodeSemaine });

            entity.ToTable("Semaine");

            entity.Property(e => e.CodeSemaine).HasMaxLength(10);
            entity.Property(e => e.DateDebutSemaine).HasColumnType("datetime");
            entity.Property(e => e.DateFinSemaine).HasColumnType("datetime");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.CodeService);

            entity.ToTable("Service");

            entity.Property(e => e.CodeService).HasMaxLength(10);
            entity.Property(e => e.Libelle).HasMaxLength(100);
        });

        modelBuilder.Entity<Sexe>(entity =>
        {
            entity.HasKey(e => e.CodeSexe);

            entity.ToTable("Sexe");

            entity.Property(e => e.CodeSexe).HasMaxLength(1);
            entity.Property(e => e.Libelle)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Societe>(entity =>
        {
            entity.HasKey(e => e.CodeSociete);

            entity.ToTable("Societe");

            entity.Property(e => e.CodeSociete).HasMaxLength(6);
            entity.Property(e => e.Adresse).HasMaxLength(1500);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCnam)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')")
                .HasColumnName("CodeCNAM");
            entity.Property(e => e.CodeForme)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodePostal).HasMaxLength(10);
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .HasColumnName("FAX");
            entity.Property(e => e.Logo).HasColumnType("image");
            entity.Property(e => e.Mail).HasMaxLength(60);
            entity.Property(e => e.MatriculeFiscale).HasMaxLength(20);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.Pays).HasMaxLength(30);
            entity.Property(e => e.RaisonSociale).HasMaxLength(600);
            entity.Property(e => e.RegistreCommerce).HasMaxLength(20);
            entity.Property(e => e.Responsable).HasMaxLength(60);
            entity.Property(e => e.RibBanquaire)
                .HasMaxLength(40)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.SiteWeb).HasMaxLength(60);
            entity.Property(e => e.Tel1).HasMaxLength(30);
            entity.Property(e => e.Tel2).HasMaxLength(30);
            entity.Property(e => e.Ville).HasMaxLength(30);
        });

        modelBuilder.Entity<SoldeClient>(entity =>
        {
            entity.HasKey(e => e.CodeClient);

            entity.ToTable("SoldeClient");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.SoldeBl)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("SoldeBL");
            entity.Property(e => e.SoldeFv)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("SoldeFV");
        });

        modelBuilder.Entity<SoldesClient>(entity =>
        {
            entity.HasKey(e => e.CodeClient);

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.SoldeClient).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<SousFamilleArticle>(entity =>
        {
            entity.HasKey(e => new { e.CodeSousFamille, e.CodeFamille });

            entity.ToTable("SousFamilleArticle");

            entity.Property(e => e.CodeSousFamille).HasMaxLength(17);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.Libelle).HasMaxLength(60);
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => new { e.CodeDepot, e.CodeArticle });

            entity.ToTable("Stock");

            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.PrixUnitaireAchat).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Qtimprimer)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("QTImprimer");
            entity.Property(e => e.QuaniteMinimale).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteMaximale).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<StockAuDate>(entity =>
        {
            entity.HasKey(e => new { e.CodeDepot, e.CodeArticle });

            entity.ToTable("StockAuDate");

            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.PrixUnitaireAchat).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.QuaniteMinimale).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteMaximale).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<StockDémarrage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StockDémarrage");

            entity.Property(e => e.CodeArticle).HasMaxLength(1050);
            entity.Property(e => e.Qte).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<StockTailleCouleur>(entity =>
        {
            entity.HasKey(e => new { e.CodeDepot, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_Caracteristiques_1");

            entity.ToTable("StockTailleCouleur");

            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(10);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<StockTemporaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stockTemporaire");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.PrixUnitaireAchat).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.QuaniteMinimale).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteMaximale).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<SuivieRepresantant>(entity =>
        {
            entity.HasKey(e => e.NumeroSuivieRepresentant);

            entity.ToTable("SuivieRepresantant");

            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.DateDebut).HasColumnType("datetime");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.TypeSuivie).HasMaxLength(150);
        });

        modelBuilder.Entity<SuprimerMoi>(entity =>
        {
            entity.HasKey(e => e.CodeClient);

            entity.ToTable("SuprimerMoi");

            entity.Property(e => e.CodeClient).HasMaxLength(50);
            entity.Property(e => e.CompteComptable).HasMaxLength(50);
        });

        modelBuilder.Entity<Tabless>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureVente, e.CodeArticle, e.NumeroOrdre }).HasName("PK_TABLE");

            entity.ToTable("TABLEss");

            entity.Property(e => e.NumeroFactureVente).HasMaxLength(50);
            entity.Property(e => e.CodeArticle).HasMaxLength(50);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(50);
        });

        modelBuilder.Entity<TailleCouleurLigneAvoirAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvoirAchat, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneAvanceAchat");

            entity.ToTable("TailleCouleurLigneAvoirAchat");

            entity.Property(e => e.NumeroAvoirAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneAvoirVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvoirVente, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneAvanceVente");

            entity.ToTable("TailleCouleurLigneAvoirVente");

            entity.Property(e => e.NumeroAvoirVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneBonCommandeAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeAchat, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneBonCommandeAchat");

            entity.ToTable("TailleCouleurLigneBonCommandeAchat");

            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneBonCommandeVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeVente, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneBonCommandeVente");

            entity.ToTable("TailleCouleurLigneBonCommandeVente");

            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneBonEntrer>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonEntrer, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneBonEntrer");

            entity.ToTable("TailleCouleurLigneBonEntrer");

            entity.Property(e => e.NumeroBonEntrer).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneBonLivraisonAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonAchat, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneBonLivraisonAchat");

            entity.ToTable("TailleCouleurLigneBonLivraisonAchat");

            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneBonLivraisonVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonVente, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneBonLivraisonVente");

            entity.ToTable("TailleCouleurLigneBonLivraisonVente");

            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneBonSortie>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonSortie, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneBonSortie");

            entity.ToTable("TailleCouleurLigneBonSortie");

            entity.Property(e => e.NumeroBonSortie).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneBonTransfert>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonTransfert, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneBonTransfert");

            entity.ToTable("TailleCouleurLigneBonTransfert");

            entity.Property(e => e.NumeroBonTransfert).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneDevisVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroDevisVente, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneDevisVente");

            entity.ToTable("TailleCouleurLigneDevisVente");

            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneFactureAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureAchat, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneFactureAchat");

            entity.ToTable("TailleCouleurLigneFactureAchat");

            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneFactureVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureVente, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneFactureVente");

            entity.ToTable("TailleCouleurLigneFactureVente");

            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneInventaire>(entity =>
        {
            entity.HasKey(e => new { e.NumeroInventaire, e.CodeArticle, e.CodeCouleur, e.Taille }).HasName("PK_DetailLigneInventaire");

            entity.ToTable("TailleCouleurLigneInventaire");

            entity.Property(e => e.NumeroInventaire).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TailleCouleurLigneOrdreFabrication>(entity =>
        {
            entity.HasKey(e => new { e.NumeroDevisVente, e.CodeArticle, e.CodeCouleur, e.Taille });

            entity.ToTable("TailleCouleurLigneOrdreFabrication");

            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.Taille).HasMaxLength(2);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<TemporaireSuivieStock>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("TemporaireSuivieStock");

            entity.Property(e => e.CodeArticle)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Qtachat)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTAchat");
            entity.Property(e => e.QtstockActuel)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTStockActuel");
            entity.Property(e => e.Qtvente)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTVente");
        });

        modelBuilder.Entity<Tracabilite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tracabil__3213E83F1F8F5C77");

            entity.ToTable("Tracabilite");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.NomTable).HasMaxLength(255);
            entity.Property(e => e.TypeAction).HasMaxLength(255);
        });

        modelBuilder.Entity<TraceAvanceClient>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvanceClient, e.DateMaj, e.HeureMaj }).HasName("PK_Trace_AvanceClient");

            entity.ToTable("TraceAvanceClient");

            entity.Property(e => e.NumeroAvanceClient).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceAvanceFournisseur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvanceFournisseur, e.DateMaj, e.HeureMaj }).HasName("PK_Trace_AvanceFournisseur");

            entity.ToTable("TraceAvanceFournisseur");

            entity.Property(e => e.NumeroAvanceFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceAvoirAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvoirAchat, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceAvoirAchat");

            entity.Property(e => e.NumeroAvoirAchat).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceAvoirVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvoirVente, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceAvoirVente");

            entity.Property(e => e.NumeroAvoirVente).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonCommandeAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeAchat, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceBonCommandeAchat");

            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonCommandeVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeVente, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceBonCommandeVente");

            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonEntrer>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonEntrer, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceBonEntrer");

            entity.Property(e => e.NumeroBonEntrer).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonLivraisonAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonAchat, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceBonLivraisonAchat");

            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonLivraisonVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonVente, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceBonLivraisonVente");

            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonRetourAchat>(entity =>
        {
            entity.HasKey(e => e.NumeroBonRetourAchat);

            entity.ToTable("TraceBonRetourAchat");

            entity.Property(e => e.NumeroBonRetourAchat).HasMaxLength(10);
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonRetourVente>(entity =>
        {
            entity.HasKey(e => e.NumeroBonRetourVente);

            entity.ToTable("TraceBonRetourVente");

            entity.Property(e => e.NumeroBonRetourVente).HasMaxLength(10);
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonSortie>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonSortie, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceBonSortie");

            entity.Property(e => e.NumeroBonSortie).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceBonTransfert>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonTransfert, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceBonTransfert");

            entity.Property(e => e.NumeroBonTransfert).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceDetailReglementClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TraceDetailReglementClient");

            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroPieceClient).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(2)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceDetailReglementFournisseur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroPieceFournisseur, e.CodeModeReglement, e.Reference, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceDetailReglementFournisseur");

            entity.Property(e => e.NumeroPieceFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceDevisVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroDevisVente, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceDevisVente");

            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceFactureAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureAchat, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceFactureAchat");

            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceFactureExport>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureExport, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceFactureExport");

            entity.Property(e => e.NumeroFactureExport).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceFactureVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureVente, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceFactureVente");

            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceInventaire>(entity =>
        {
            entity.HasKey(e => new { e.NumeroInventaire, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceInventaire");

            entity.Property(e => e.NumeroInventaire).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceMouvementCompte>(entity =>
        {
            entity.HasKey(e => new { e.NumeroMouvement, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceMouvementCompte");

            entity.Property(e => e.NumeroMouvement).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TracePreFacture>(entity =>
        {
            entity.HasKey(e => new { e.NumeroPreFacture, e.DateMaj, e.HeureMaj });

            entity.ToTable("TracePreFacture");

            entity.Property(e => e.NumeroPreFacture).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceReglementClient>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementClient, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceReglementClient");

            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<TraceReglementFournisseur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroReglementFournisseur, e.DateMaj, e.HeureMaj });

            entity.ToTable("TraceReglementFournisseur");

            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateMaj)
                .HasColumnType("datetime")
                .HasColumnName("DateMAJ");
            entity.Property(e => e.HeureMaj)
                .HasColumnType("datetime")
                .HasColumnName("HeureMAJ");
            entity.Property(e => e.AncienTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NouveauTotal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeMaj)
                .HasMaxLength(1)
                .HasColumnName("TypeMAJ");
        });

        modelBuilder.Entity<Transfert>(entity =>
        {
            entity.HasKey(e => e.NumeroTransfert);

            entity.ToTable("Transfert");

            entity.Property(e => e.NumeroTransfert).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateTransfert)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Libelle)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroBordereau)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(500);
        });

        modelBuilder.Entity<Tva>(entity =>
        {
            entity.HasKey(e => e.CodeTva);

            entity.ToTable("TVA");

            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvaavoirAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvoirAchat, e.CodeTva }).HasName("PK_TVAAvoirAchat_1");

            entity.ToTable("TVAAvoirAchat");

            entity.Property(e => e.NumeroAvoirAchat).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvaavoirVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAvoirVente, e.CodeTva }).HasName("PK_TVAAvoirVente_1");

            entity.ToTable("TVAAvoirVente");

            entity.Property(e => e.NumeroAvoirVente).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonCommandeAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeAchat, e.CodeTva });

            entity.ToTable("TVABonCommandeAchat");

            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonCommandeVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonCommandeVente, e.CodeTva }).HasName("PK_TVACommandeVente");

            entity.ToTable("TVABonCommandeVente");

            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonEntrer>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonEntrer, e.CodeTva });

            entity.ToTable("TVABonEntrer");

            entity.Property(e => e.NumeroBonEntrer).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonLivraisonAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonAchat, e.CodeTva });

            entity.ToTable("TVABonLivraisonAchat");

            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonLivraisonVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonLivraisonVente, e.CodeTva }).HasName("PK_TVABonLivraisonVente_1");

            entity.ToTable("TVABonLivraisonVente");

            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonRetourAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonRetourAchat, e.CodeTva });

            entity.ToTable("TVABonRetourAchat");

            entity.Property(e => e.NumeroBonRetourAchat).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonRetourLivreur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonRetourLivreur, e.CodeTva });

            entity.ToTable("TVABonRetourLivreur");

            entity.Property(e => e.NumeroBonRetourLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonRetourVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonRetourVente, e.CodeTva });

            entity.ToTable("TVABonRetourVente");

            entity.Property(e => e.NumeroBonRetourVente).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonSortie>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonSortie, e.CodeTva });

            entity.ToTable("TVABonSortie");

            entity.Property(e => e.NumeroBonSortie).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonSortieLivreur>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonSortieLivreur, e.CodeTva });

            entity.ToTable("TVABonSortieLivreur");

            entity.Property(e => e.NumeroBonSortieLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvabonTransfert>(entity =>
        {
            entity.HasKey(e => new { e.NumeroBonTransfert, e.CodeTva });

            entity.ToTable("TVABonTransfert");

            entity.Property(e => e.NumeroBonTransfert).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvadevisVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroDevisVente, e.CodeTva });

            entity.ToTable("TVADevisVente");

            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvafactureAchat>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureAchat, e.CodeTva }).HasName("PK_TVAFacturesAchat");

            entity.ToTable("TVAFactureAchat");

            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvafactureAchatDiver>(entity =>
        {
            entity.HasKey(e => new { e.NumeroAchatDiver, e.CodeTva }).HasName("PK_TVAAchatDiver");

            entity.ToTable("TVAFactureAchatDiver");

            entity.Property(e => e.NumeroAchatDiver).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvafactureExport>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureExport, e.CodeTva });

            entity.ToTable("TVAFactureExport");

            entity.Property(e => e.NumeroFactureExport).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvafactureExportTnd>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureExport, e.CodeTva });

            entity.ToTable("TVAFactureExportTND");

            entity.Property(e => e.NumeroFactureExport).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvafactureVente>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFactureVente, e.CodeTva });

            entity.ToTable("TVAFactureVente");

            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TvaficheIntervention>(entity =>
        {
            entity.HasKey(e => new { e.NumeroFicheIntervention, e.CodeTva });

            entity.ToTable("TVAFicheIntervention");

            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<Tvaprefacture>(entity =>
        {
            entity.HasKey(e => new { e.NumeroPreFacture, e.CodeTva });

            entity.ToTable("TVAPrefacture");

            entity.Property(e => e.NumeroPreFacture).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.BaseHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BaseHT");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<TypeArticle>(entity =>
        {
            entity.HasKey(e => e.CodeType);

            entity.ToTable("TypeArticle");

            entity.Property(e => e.CodeType).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(60);
        });

        modelBuilder.Entity<TypeContrat>(entity =>
        {
            entity.HasKey(e => e.CodeTypeContrat);

            entity.ToTable("TypeContrat");

            entity.Property(e => e.CodeTypeContrat).HasMaxLength(10);
            entity.Property(e => e.Libelle).HasMaxLength(200);
        });

        modelBuilder.Entity<TypeDepense>(entity =>
        {
            entity.HasKey(e => e.CodeTypeDepense);

            entity.ToTable("TypeDepense");

            entity.Property(e => e.CodeTypeDepense).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(160);
        });

        modelBuilder.Entity<TypeTransport>(entity =>
        {
            entity.HasKey(e => e.CodeTypeTransport).HasName("PK_TypeTransports");

            entity.ToTable("TypeTransport");

            entity.Property(e => e.CodeTypeTransport).HasMaxLength(16);
            entity.Property(e => e.Libelle).HasMaxLength(255);
        });

        modelBuilder.Entity<TypeVente>(entity =>
        {
            entity.HasKey(e => e.CodeTypeVente);

            entity.ToTable("TypeVente");

            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.Libelle).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeVisite>(entity =>
        {
            entity.HasKey(e => e.CodeTypeVisite);

            entity.ToTable("TypeVisite");

            entity.Property(e => e.CodeTypeVisite).HasMaxLength(30);
            entity.Property(e => e.Libelle).HasMaxLength(300);
        });

        modelBuilder.Entity<UniteArticle>(entity =>
        {
            entity.HasKey(e => e.CodeUnite);

            entity.ToTable("UniteArticle");

            entity.Property(e => e.CodeUnite).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(60);
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.NomUtilisateur);

            entity.ToTable("Utilisateur");

            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.Actif)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.CodeDepot)
                .HasMaxLength(6)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeFonction).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeSociete).HasMaxLength(6);
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Nom)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PlafondTauxRemiseVente).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Prenom)
                .HasMaxLength(30)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<ValidationDecaissement>(entity =>
        {
            entity.HasKey(e => e.NumeroValidation);

            entity.ToTable("ValidationDecaissement");

            entity.Property(e => e.NumeroValidation).HasMaxLength(10);
            entity.Property(e => e.CodeBanque).HasMaxLength(10);
            entity.Property(e => e.CodeCompte)
                .HasMaxLength(35)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.CodeModeReglement)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDebutEcheance).HasColumnType("datetime");
            entity.Property(e => e.DateFinEcheance).HasColumnType("datetime");
            entity.Property(e => e.DateValidation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.MontantGlobal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(30);
        });

        modelBuilder.Entity<Versement>(entity =>
        {
            entity.HasKey(e => e.NumeroVersement);

            entity.ToTable("Versement");

            entity.Property(e => e.NumeroVersement).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateVersement)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Libelle)
                .HasMaxLength(300)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(500);
        });

        modelBuilder.Entity<VueArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteTTC");
            entity.Property(e => e.QteRestante).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueAvanceFournisseur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueAvanceFournisseur");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateAvance).HasColumnType("datetime");
            entity.Property(e => e.EtatAvance).HasMaxLength(10);
            entity.Property(e => e.MontantAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NetAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroAvanceFournisseur).HasMaxLength(10);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<VueBonCommandeVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueBonCommandeVente");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(30);
            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.DateBonCommandeVente).HasColumnType("datetime");
            entity.Property(e => e.Nbpiece)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("NBPiece");
            entity.Property(e => e.NomPrenomLivreur).HasMaxLength(200);
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.Numeroetat)
                .HasMaxLength(3)
                .HasColumnName("numeroetat");
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
        });

        modelBuilder.Entity<VueBonLivaisonVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueBonLivaisonVente");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.DateBonLivraisonVente).HasColumnType("datetime");
            entity.Property(e => e.Nbpiece)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("NBPiece");
            entity.Property(e => e.NomPrenomLivreur).HasMaxLength(200);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.Numeroetat)
                .HasMaxLength(3)
                .HasColumnName("numeroetat");
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
        });

        modelBuilder.Entity<VueBonRetourVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueBonRetourVente");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.DateBonRetourVente).HasColumnType("datetime");
            entity.Property(e => e.Nbpiece)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("NBPiece");
            entity.Property(e => e.NomPrenomLivreur).HasMaxLength(200);
            entity.Property(e => e.NumeroBonRetourVente).HasMaxLength(10);
            entity.Property(e => e.Numeroetat)
                .HasMaxLength(3)
                .HasColumnName("numeroetat");
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
        });

        modelBuilder.Entity<VueControleAccee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ControleAccee");

            entity.Property(e => e.Libelle).HasMaxLength(60);
            entity.Property(e => e.NomMenu).HasMaxLength(60);
            entity.Property(e => e.NomMenuParent).HasMaxLength(60);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
        });

        modelBuilder.Entity<VueDepence>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_Depence");

            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateDepence).HasColumnType("datetime");
            entity.Property(e => e.LibelleDepense).HasMaxLength(300);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroDepence).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(150);
            entity.Property(e => e.Proteur).HasMaxLength(70);
            entity.Property(e => e.TypeDepence).HasMaxLength(160);
        });

        modelBuilder.Entity<VueDepotArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueDepotArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.Depot).HasMaxLength(60);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.FamilleArticle).HasMaxLength(60);
            entity.Property(e => e.LiteTauxRemise).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.MarqueArticle).HasMaxLength(60);
            entity.Property(e => e.PrixUnitaireAchat).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteTTC");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RaisonSociale).HasMaxLength(60);
        });

        modelBuilder.Entity<VueDesCommutionRepresentant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_DesCommutionRepresentant");

            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.DateCommution).HasColumnType("datetime");
            entity.Property(e => e.DateDebut).HasColumnType("datetime");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NumeroCommution).HasMaxLength(50);
            entity.Property(e => e.Observation).HasMaxLength(1500);
        });

        modelBuilder.Entity<VueDetailEntrerSortieArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_DetailEntrerSortieArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.Entree).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.HeureCreaion).HasColumnType("datetime");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Operation)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PrixUnitaire).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Sortie).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Tier).HasMaxLength(160);
        });

        modelBuilder.Entity<VueDetailLettrage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_DetailLettrage");

            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.TotalPayee).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypePiece)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VueDetailReglementClientFacturer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_DetailReglementClientFacturer");

            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantVerser).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroBordereau).HasMaxLength(50);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<VueDetailRemplacementClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_DetailRemplacementClient");

            entity.Property(e => e.AncienCodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.AncienReference).HasMaxLength(20);
            entity.Property(e => e.AncienReglement).HasMaxLength(10);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NewCodeModeReglement)
                .HasMaxLength(6)
                .HasColumnName("newCodeModeReglement");
            entity.Property(e => e.NewReference).HasMaxLength(20);
            entity.Property(e => e.NewReglement).HasMaxLength(10);
        });

        modelBuilder.Entity<VueEtatArticleBc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_EtatArticleBC");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.DateBonCommandeVente).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleMarque).HasMaxLength(60);
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueEtatArticleBl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_EtatArticleBL");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.DateBonLivraisonVente).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleMarque).HasMaxLength(60);
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueEtatArticleFacture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_EtatArticleFacture");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.DateFactureVente).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleMarque).HasMaxLength(60);
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueEtatArticleNonVendu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_EtatArticleNonVendu");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.DateBonLivraisonVente).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueEtatArticleVendu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_EtatArticleVendu");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.DateBonLivraisonVente).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleMarque).HasMaxLength(60);
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueFactureBonLivraison>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_FactureBonLivraison");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueFicheInterventionAvecService>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueFicheInterventionAvecService");

            entity.Property(e => e.Afacturer).HasColumnName("AFacturer");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeIntervenant).HasMaxLength(10);
            entity.Property(e => e.CodeNatureIntervention).HasMaxLength(10);
            entity.Property(e => e.CodeService).HasMaxLength(10);
            entity.Property(e => e.ComposantUtiliser).HasMaxLength(1500);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateFicheIntervention).HasColumnType("datetime");
            entity.Property(e => e.Duree).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Etat)
                .HasMaxLength(30)
                .HasColumnName("etat");
            entity.Property(e => e.Expr1).HasMaxLength(10);
            entity.Property(e => e.Expr10).HasMaxLength(10);
            entity.Property(e => e.Expr11).HasMaxLength(10);
            entity.Property(e => e.Expr12).HasMaxLength(1500);
            entity.Property(e => e.Expr13).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Expr14).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Expr15).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Expr16).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Expr17).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Expr18).HasMaxLength(10);
            entity.Property(e => e.Expr19).HasMaxLength(6);
            entity.Property(e => e.Expr2).HasColumnType("datetime");
            entity.Property(e => e.Expr20).HasMaxLength(3);
            entity.Property(e => e.Expr3).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Expr4).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Expr5).HasMaxLength(10);
            entity.Property(e => e.Expr6).HasMaxLength(20);
            entity.Property(e => e.Expr7).HasColumnType("datetime");
            entity.Property(e => e.Expr8).HasColumnType("datetime");
            entity.Property(e => e.Expr9).HasMaxLength(1500);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Libelle).HasMaxLength(100);
            entity.Property(e => e.LibelleIntervantion).HasMaxLength(1500);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
            entity.Property(e => e.NumeroPieceVente).HasMaxLength(10);
            entity.Property(e => e.NumeroReception).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.Reclamation).HasMaxLength(1500);
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueLigneAvoirAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneAvoirAchat");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroAvoirAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.ReferenceFournisseur).HasMaxLength(20);
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneAvoirVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneAvoirVente");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroAvoirVente).HasMaxLength(10);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonCommandeAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonCommandeAchat");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonCommandeVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonCommandeVente");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonEntrer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonEntrer");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NumeroBonEntrer).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonLivraisonAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonLivraisonAchat");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeArticleFournisseur).HasMaxLength(60);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.Nbimpression).HasColumnName("NBImpression");
            entity.Property(e => e.Nbvalise).HasColumnName("NBValise");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PuenDevise)
                .HasColumnType("numeric(38, 23)")
                .HasColumnName("PUEnDevise");
            entity.Property(e => e.Qtimprimer)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("QTImprimer");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonLivraisonVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonLivraisonVente");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonRetourAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonRetourAchat");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonRetourAchat).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonRetourVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonRetourVente");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonRetourVente).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonSortie>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonSortie");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NumeroBonSortie).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBonTransfert>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBonTransfert");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NumeroBonTransfert).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneBordereauEscompte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneBordereauEscompte");

            entity.Property(e => e.CodeModeReglement).HasMaxLength(20);
            entity.Property(e => e.DateFactureVente).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroBordereau).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(25);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(20);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
        });

        modelBuilder.Entity<VueLigneContratClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_LigneContratClient");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeTypeContrat).HasMaxLength(10);
            entity.Property(e => e.DateDebut).HasColumnType("datetime");
            entity.Property(e => e.DateFacturation).HasMaxLength(10);
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.DateQuittance).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleTypeContrat).HasMaxLength(200);
            entity.Property(e => e.ModeFacturation).HasMaxLength(20);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.NumeroContratClient).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<VueLigneDemandePrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_LigneDemandePrix");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.NumeroDemandePrix).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueLigneDevisVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneDevisVente");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(4000);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneFactureAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneFactureAchat");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeArticleFournisseur).HasMaxLength(60);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixAchatHtchange)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHTChange");
            entity.Property(e => e.PrixAchatHtdevise)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHTDevise");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneFactureAchatDiver>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneFactureAchatDivers");

            entity.Property(e => e.DesignationArticle).HasMaxLength(300);
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroAchatDiver).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneFactureExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneFactureExport");

            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Cat).HasMaxLength(50);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroFactureExport).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PoidsNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pointure).HasMaxLength(50);
            entity.Property(e => e.PrePack).HasMaxLength(50);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneFactureExportTnd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneFactureExportTND");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroFactureExportTnd)
                .HasMaxLength(10)
                .HasColumnName("NumeroFactureExportTND");
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PoidsNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneFactureVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneFactureVente");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneFicheIntervention>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneFicheIntervention");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneInventaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLigneInventaire");

            entity.Property(e => e.AncienneQuantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.NouvelleQuantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroInventaire).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(500);
            entity.Property(e => e.PrixInventaire).HasColumnType("numeric(18, 5)");
        });

        modelBuilder.Entity<VueLignePreFacture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_LignePreFacture");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(6);
            entity.Property(e => e.DesignationArticle).HasMaxLength(200);
            entity.Property(e => e.DesignationParent).HasMaxLength(300);
            entity.Property(e => e.Libelle).HasMaxLength(30);
            entity.Property(e => e.MontantAvanceImpot).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroPreFacture).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PoidsNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pointure).HasMaxLength(7);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLignePrefacture1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueLignePrefacture");

            entity.Property(e => e.Brand).HasMaxLength(50);
            entity.Property(e => e.Cat).HasMaxLength(50);
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.Designation).HasMaxLength(200);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroPreFacture).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PoidsBrut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PoidsNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pointure).HasMaxLength(50);
            entity.Property(e => e.PrePack).HasMaxLength(50);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteCarton).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueLigneReglementClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_LigneReglementClient");

            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.MontantPieceTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantPieceTTC");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.TotalPayee).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.Totalretenu).HasColumnType("numeric(38, 3)");
        });

        modelBuilder.Entity<VueListeAfacturer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeAFacturer");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateBonLivraisonVente).HasColumnType("datetime");
            entity.Property(e => e.MatriculeFiscale).HasMaxLength(20);
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeBarre).HasMaxLength(80);
            entity.Property(e => e.CodeCalibre).HasMaxLength(10);
            entity.Property(e => e.CodeCouleur).HasMaxLength(10);
            entity.Property(e => e.CodeEtui).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.CodeSexe).HasMaxLength(1);
            entity.Property(e => e.CodeSousFamille).HasMaxLength(17);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.CodeType).HasMaxLength(6);
            entity.Property(e => e.CodeUnite).HasMaxLength(6);
            entity.Property(e => e.CodeUniteVente).HasMaxLength(6);
            entity.Property(e => e.DernierPrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("DernierPrixAchatHT");
            entity.Property(e => e.DernierPrixDevise).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.DernierTauxRemise).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleFamille).HasMaxLength(60);
            entity.Property(e => e.LibelleMarque).HasMaxLength(60);
            entity.Property(e => e.Libelletype).HasMaxLength(60);
            entity.Property(e => e.LiteTauxRemise).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Marge).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Observation).HasMaxLength(500);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteTTC");
            entity.Property(e => e.Reference).HasMaxLength(10);
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
            entity.Property(e => e.ValeurUniteVente).HasColumnType("numeric(18, 5)");
        });

        modelBuilder.Entity<VueListeArticleEnStockParDatePremierAchatEtDernierDateAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeArticleEnStockParDatePremierAchatEtDernierDateAchat");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.DernierAchat).HasMaxLength(10);
            entity.Property(e => e.PremierAchat).HasMaxLength(10);
            entity.Property(e => e.PrixUnitaireAchat).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Qtimprimer)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("QTImprimer");
            entity.Property(e => e.QuaniteMinimale).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QuantiteMaximale).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueListeArticleFournisseur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeArticleFournisseur");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeArticleFournisseur).HasMaxLength(60);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.DernierPrixAchat).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<VueListeAvanceClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeAvanceClient");

            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateAvance).HasColumnType("datetime");
            entity.Property(e => e.EtatAvance).HasMaxLength(30);
            entity.Property(e => e.MontantAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroAvanceClient).HasMaxLength(10);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<VueListeAvanceFournisseur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeAvanceFournisseur");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateAvance).HasColumnType("datetime");
            entity.Property(e => e.EtatAvance).HasMaxLength(30);
            entity.Property(e => e.Fournisseur).HasMaxLength(60);
            entity.Property(e => e.MontantAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroAvanceFournisseur).HasMaxLength(10);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<VueListeAvoirAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeAvoirAchat");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateAvoirAchat).HasColumnType("datetime");
            entity.Property(e => e.NumeroAvoirAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(60);
            entity.Property(e => e.ReferenceFournisseur).HasMaxLength(20);
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeAvoirVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeAvoirVente");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateAvoirVente).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.NumeroAvoirVente).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonCommandeAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonCommandeAchat");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateBonCommandeAchat).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.Fournisseur).HasMaxLength(60);
            entity.Property(e => e.NumeroBonCommandeAchat).HasMaxLength(10);
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonCommandeVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonCommandeVente");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateBonCommandeVente).HasColumnType("datetime");
            entity.Property(e => e.Libelle).HasMaxLength(30);
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.ReferenceClient).HasMaxLength(20);
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonEntrer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonEntrer");

            entity.Property(e => e.DateBonEntrer).HasColumnType("datetime");
            entity.Property(e => e.Depot).HasMaxLength(60);
            entity.Property(e => e.NumeroBonEntrer).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(9, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonLivraisonAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonLivraisonAchat");

            entity.Property(e => e.Bldevise).HasColumnName("BLDevise");
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateBonLivraisonAchat).HasColumnType("datetime");
            entity.Property(e => e.Depot).HasMaxLength(60);
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.FraisTransport).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.RaisonSociale).HasMaxLength(60);
            entity.Property(e => e.ReferenceFournisseur).HasMaxLength(20);
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
        });

        modelBuilder.Entity<VueListeBonLivraisonVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonLivraisonVente");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.DateBonLivraisonVente).HasColumnType("datetime");
            entity.Property(e => e.DateCommande).HasColumnType("datetime");
            entity.Property(e => e.DateLivraison).HasColumnType("datetime");
            entity.Property(e => e.DateValidation).HasColumnType("datetime");
            entity.Property(e => e.Libelle).HasMaxLength(30);
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomValideur).HasMaxLength(10);
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRestant).HasColumnType("numeric(19, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonRetourAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonRetourAchat");

            entity.Property(e => e.DateBonRetourAchat).HasColumnType("datetime");
            entity.Property(e => e.Depot).HasMaxLength(60);
            entity.Property(e => e.NumeroBonLivraisonAchat).HasMaxLength(10);
            entity.Property(e => e.NumeroBonRetourAchat).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(60);
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
        });

        modelBuilder.Entity<VueListeBonRetourLivreur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeBonRetourLivreur");

            entity.Property(e => e.CodeDepotLivreur).HasMaxLength(6);
            entity.Property(e => e.CodeDepotRetour).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.DateBonRetourLivreur).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibelleCamion).HasMaxLength(200);
            entity.Property(e => e.LibelleDepot).HasMaxLength(60);
            entity.Property(e => e.LibelleEtat).HasMaxLength(30);
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroBonRetourLivreur).HasMaxLength(10);
            entity.Property(e => e.NumeroBonSortieLivreur).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonRetourVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonRetourVente");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.DateBonRetourVente).HasColumnType("datetime");
            entity.Property(e => e.DateCommande).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Depot).HasMaxLength(60);
            entity.Property(e => e.Expr1).HasMaxLength(10);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibelleEtat).HasMaxLength(30);
            entity.Property(e => e.MontantRemiseExceptionnel).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroAvoirVente).HasMaxLength(10);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.NumeroBonRetourVente).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonSortie>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonSortie");

            entity.Property(e => e.DateBonSortie).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Depot).HasMaxLength(60);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroBonSortie).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonSortieLivreur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeBonSortieLivreur");

            entity.Property(e => e.CodeCamion).HasMaxLength(10);
            entity.Property(e => e.CodeDepotDestignation).HasMaxLength(6);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.DateBonSortieLivreur).HasColumnType("datetime");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DepotSource).HasMaxLength(6);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibelleCamion).HasMaxLength(200);
            entity.Property(e => e.LibelleEtat).HasMaxLength(30);
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroBonSortieLivreur).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBonTransfert>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeBonTransfert");

            entity.Property(e => e.CodeCamion).HasMaxLength(50);
            entity.Property(e => e.DateBonTransfert).HasColumnType("datetime");
            entity.Property(e => e.DateRetour).HasColumnType("datetime");
            entity.Property(e => e.DepotDestination).HasMaxLength(60);
            entity.Property(e => e.DepotSource).HasMaxLength(60);
            entity.Property(e => e.NumeroBonTransfert).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeBordereauVersementPourConsultation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeBordereauVersementPourConsultation");

            entity.Property(e => e.Banque).HasMaxLength(60);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantCommution).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantLettre).HasMaxLength(1500);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRestant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MontantVerser).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroBordereau).HasMaxLength(50);
            entity.Property(e => e.NumeroCommution).HasMaxLength(50);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroOperationRecu).HasMaxLength(50);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Porteur).HasMaxLength(255);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.Rib)
                .HasMaxLength(255)
                .HasColumnName("RIB");
            entity.Property(e => e.TauxCommution).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<VueListeCamion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeCamion");

            entity.Property(e => e.CodeCamion).HasMaxLength(10);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.Libelle).HasMaxLength(200);
            entity.Property(e => e.LibelleDepot).HasMaxLength(60);
            entity.Property(e => e.Martricule).HasMaxLength(60);
            entity.Property(e => e.Observation).HasMaxLength(300);
        });

        modelBuilder.Entity<VueListeClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeClient");

            entity.Property(e => e.Activite).HasMaxLength(1500);
            entity.Property(e => e.Adresse1).HasMaxLength(1000);
            entity.Property(e => e.Adresse2).HasMaxLength(1000);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeClientParent).HasMaxLength(10);
            entity.Property(e => e.CodeFamille).HasMaxLength(6);
            entity.Property(e => e.CodeForme).HasMaxLength(6);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodePostal1).HasMaxLength(10);
            entity.Property(e => e.CodePostal2).HasMaxLength(10);
            entity.Property(e => e.CodeZoneClient).HasMaxLength(10);
            entity.Property(e => e.CompteComptable).HasMaxLength(20);
            entity.Property(e => e.DateDebutExoneration).HasColumnType("datetime");
            entity.Property(e => e.DateDernierBl)
                .HasMaxLength(10)
                .HasColumnName("DateDernierBL");
            entity.Property(e => e.DateFinExoneration).HasColumnType("datetime");
            entity.Property(e => e.Fax1).HasMaxLength(30);
            entity.Property(e => e.Fax2).HasMaxLength(30);
            entity.Property(e => e.Mail).HasMaxLength(60);
            entity.Property(e => e.MatriculeFiscale).HasMaxLength(20);
            entity.Property(e => e.NumeroExoneration).HasMaxLength(60);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PayerTva).HasColumnName("PayerTVA");
            entity.Property(e => e.Pays1).HasMaxLength(30);
            entity.Property(e => e.Pays2).HasMaxLength(30);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.Region).HasMaxLength(150);
            entity.Property(e => e.RegistreCommerce).HasMaxLength(20);
            entity.Property(e => e.Representant).HasMaxLength(200);
            entity.Property(e => e.Responsable).HasMaxLength(160);
            entity.Property(e => e.RibBanquaire).HasMaxLength(20);
            entity.Property(e => e.SeuilCredit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SeuilMaximum).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SeuilMinimum).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.SiteWeb).HasMaxLength(60);
            entity.Property(e => e.SoldeClient).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Tel1).HasMaxLength(30);
            entity.Property(e => e.Tel2).HasMaxLength(30);
            entity.Property(e => e.Ville1).HasMaxLength(30);
            entity.Property(e => e.Ville2).HasMaxLength(30);
        });

        modelBuilder.Entity<VueListeClientPayerNonFacturer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeClientPayerNonFacturer");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(38, 3)");
        });

        modelBuilder.Entity<VueListeCommution>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeCommution");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantCommution).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NumeroCommution).HasMaxLength(50);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TauxCommution).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<VueListeContratClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeContratClient");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeTypeContrat).HasMaxLength(10);
            entity.Property(e => e.DateDebut).HasColumnType("datetime");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.DatePremiereFactration).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleTypeContrat).HasMaxLength(200);
            entity.Property(e => e.ModeFacturation).HasMaxLength(20);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.NumeroContratClient).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(500);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<VueListeDemandePrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeDemandePrix");

            entity.Property(e => e.DateDemandePrix).HasColumnType("datetime");
            entity.Property(e => e.Fournisseur).HasMaxLength(60);
            entity.Property(e => e.NumeroDemandePrix).HasMaxLength(10);
        });

        modelBuilder.Entity<VueListeDetailReglement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeDetailReglement");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Libelle).HasMaxLength(60);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(250);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<VueListeDevisVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeDevisVente");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateDevisVente).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.NumeroDevisVente).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeEncoursClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeEncoursClient");

            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.ModeReglement).HasMaxLength(60);
            entity.Property(e => e.MontantLettre).HasMaxLength(1500);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<VueListeExportation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeExportation");

            entity.Property(e => e.DateExportation).HasColumnType("datetime");
            entity.Property(e => e.Nom).HasMaxLength(30);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(30);
            entity.Property(e => e.NumeroExportation).HasMaxLength(10);
            entity.Property(e => e.Prenom).HasMaxLength(30);
        });

        modelBuilder.Entity<VueListeFactureAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeFactureAchat");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateFactureAchat).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.Fournisseur).HasMaxLength(60);
            entity.Property(e => e.NumeroFactureAchat).HasMaxLength(10);
            entity.Property(e => e.ReferenceFournisseur).HasMaxLength(20);
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeFactureAchatDiver>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeFactureAchatDivers");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateAchatDiver).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.Fournisseur).HasMaxLength(60);
            entity.Property(e => e.NumeroAchatDiver).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.ReferenceFournisseur).HasMaxLength(20);
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeFactureExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeFactureExport");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateFactureExport).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.NumeroFactureExport).HasMaxLength(10);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.NumeroPrefacture).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeFactureExportTnd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeFactureExportTND");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateFactureExportTnd)
                .HasColumnType("datetime")
                .HasColumnName("DateFactureExportTND");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.NumeroFactureExportTnd)
                .HasMaxLength(10)
                .HasColumnName("NumeroFactureExportTND");
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.NumeroPrefacture).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeFactureVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeFactureVente");

            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateFactureVente).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeFicheIntervention>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeFicheIntervention");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeIntervenant).HasMaxLength(10);
            entity.Property(e => e.CodeNatureIntervention).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateFicheIntervention).HasColumnType("datetime");
            entity.Property(e => e.Duree).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibelleIntervantion).HasMaxLength(1500);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
            entity.Property(e => e.NumeroPieceVente).HasMaxLength(10);
            entity.Property(e => e.NumeroReception).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeFournisseurArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeFournisseurArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeArticleFournisseur).HasMaxLength(60);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DernierPrixAchat).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.RaisonSociale).HasMaxLength(60);
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
        });

        modelBuilder.Entity<VueListeIntervenantParFiche>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeIntervenantParFiche");

            entity.Property(e => e.CodeIntervenant).HasMaxLength(10);
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NumeroFicheIntervention).HasMaxLength(10);
        });

        modelBuilder.Entity<VueListeInventaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeInventaire");

            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateInventaire).HasColumnType("datetime");
            entity.Property(e => e.DateValidation).HasColumnType("datetime");
            entity.Property(e => e.Depot).HasMaxLength(60);
            entity.Property(e => e.NumeroInventaire).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(500);
        });

        modelBuilder.Entity<VueListeLot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeLot");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Depot).HasMaxLength(60);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroLot).HasMaxLength(60);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueListeMouvementClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeMouvementClients");

            entity.Property(e => e.Client).HasMaxLength(20);
            entity.Property(e => e.Credit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Debit).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<VueListePieceAreglerPourChaqueClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListePieceAreglerPourChaqueClient");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.MontantPiece).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<VueListePrefacture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListePrefacture");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DatePrefacture).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.NumeroPrefacture).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeReceptionMateriel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeReceptionMateriel");

            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeClient).HasMaxLength(30);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReception).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibellePanne).HasMaxLength(1500);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(10);
            entity.Property(e => e.NumeroReception).HasMaxLength(10);
            entity.Property(e => e.Piece).HasMaxLength(1000);
        });

        modelBuilder.Entity<VueListeReglementClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeReglementClient");

            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueListeReglementClientDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeReglementClientDetail");

            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.Compte).HasMaxLength(50);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.ModeReglement).HasMaxLength(60);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueListeReglementClientEnCour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeReglementClientEnCour");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(50);
            entity.Property(e => e.TotalAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeReglement).HasMaxLength(1);
        });

        modelBuilder.Entity<VueListeReglementClientPayee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeReglementClientPayee");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(50);
            entity.Property(e => e.TotalAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeReglement).HasMaxLength(1);
        });

        modelBuilder.Entity<VueListeReglementFournisseur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeReglementFournisseur");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Fournisseur).HasMaxLength(60);
            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueListeReglementFournisseurDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeReglementFournisseurDetail");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.Compte).HasMaxLength(50);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.ModeReglement).HasMaxLength(60);
            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(60);
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueListeReglementFournisseurEnCour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeReglementFournisseurEnCour");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(50);
            entity.Property(e => e.TotalAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeReglement).HasMaxLength(1);
        });

        modelBuilder.Entity<VueListeReglementFournisseurPayee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeReglementFournisseurPayee");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroReglementFournisseur).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(50);
            entity.Property(e => e.TotalAvance).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TypeReglement).HasMaxLength(1);
        });

        modelBuilder.Entity<VueListeReglementParLivreur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeReglementParLivreur");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
        });

        modelBuilder.Entity<VueListeRemplacementClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueListeRemplacementClient");

            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.TotalBrute).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueListeRetenuFactureAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeRetenuFactureAchat");

            entity.Property(e => e.CodeFournisseur).HasMaxLength(20);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetenuAchat).HasColumnType("datetime");
            entity.Property(e => e.Fournisseur).HasMaxLength(60);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroRetenu).HasMaxLength(10);
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeRetenuFactureVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeRetenuFactureVente");

            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeClient).HasMaxLength(20);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateRetenuVente).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroRetenu).HasMaxLength(10);
            entity.Property(e => e.TotalRetenu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
        });

        modelBuilder.Entity<VueListeTousVenteMoinsReoursArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeTousVenteMoinsReoursArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeBarre).HasMaxLength(80);
            entity.Property(e => e.CodeCalibre).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCouleur).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeEtui).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeFamilleClient).HasMaxLength(6);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.CodeSexe).HasMaxLength(1);
            entity.Property(e => e.CodeType).HasMaxLength(6);
            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.CodeUniteVente).HasMaxLength(6);
            entity.Property(e => e.CodeZoneClient)
                .HasMaxLength(10)
                .HasColumnName("codeZoneClient");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibelleFamilleArticle).HasMaxLength(60);
            entity.Property(e => e.LibelleFamilleClient).HasMaxLength(60);
            entity.Property(e => e.LibelleMarque).HasMaxLength(60);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NomRepresentant).HasMaxLength(200);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixUvente)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixUVente");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RaisonSociale).HasMaxLength(600);
            entity.Property(e => e.RaisonSocialeClient).HasMaxLength(160);
            entity.Property(e => e.RaisonSocialeFournisseur).HasMaxLength(60);
            entity.Property(e => e.Reference).HasMaxLength(30);
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.Zone).HasMaxLength(30);
        });

        modelBuilder.Entity<VueListeVenteArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ListeVenteArticle");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeBarre).HasMaxLength(80);
            entity.Property(e => e.CodeCalibre).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCouleur).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.CodeEtui).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeFamilleClient).HasMaxLength(6);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.CodeSexe).HasMaxLength(1);
            entity.Property(e => e.CodeType).HasMaxLength(6);
            entity.Property(e => e.CodeTypeVente).HasMaxLength(10);
            entity.Property(e => e.CodeUniteVente).HasMaxLength(6);
            entity.Property(e => e.CodeZoneClient)
                .HasMaxLength(10)
                .HasColumnName("codeZoneClient");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.LibelleFamilleArticle).HasMaxLength(60);
            entity.Property(e => e.LibelleFamilleClient).HasMaxLength(60);
            entity.Property(e => e.LibelleMarque).HasMaxLength(60);
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NomRepresentant).HasMaxLength(200);
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixUvente)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("PrixUVente");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RaisonSociale).HasMaxLength(600);
            entity.Property(e => e.RaisonSocialeClient).HasMaxLength(160);
            entity.Property(e => e.RaisonSocialeFournisseur).HasMaxLength(60);
            entity.Property(e => e.Reference).HasMaxLength(30);
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxRemiseExceptionnel).HasColumnType("numeric(18, 9)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
            entity.Property(e => e.TotalHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalHT");
            entity.Property(e => e.TotalNetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalNetHT");
            entity.Property(e => e.TotalRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.TotalTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTVA");
            entity.Property(e => e.Zone).HasMaxLength(30);
        });

        modelBuilder.Entity<VueMouvementCompte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueMouvementCompte");

            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Compte).HasMaxLength(50);
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateMouvement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Libelle).HasMaxLength(300);
            entity.Property(e => e.Montant).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroMouvement).HasMaxLength(10);
            entity.Property(e => e.Observation).HasMaxLength(500);
            entity.Property(e => e.RaisonSociale).HasMaxLength(60);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TypeMouvement).HasMaxLength(1);
        });

        modelBuilder.Entity<VueMouvementStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_MouvementStock");

            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Nature)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.Opération)
                .HasMaxLength(33)
                .IsUnicode(false);
            entity.Property(e => e.Utilisateur).HasMaxLength(61);
        });

        modelBuilder.Entity<VueObjectifParZone>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ObjectifParZone");

            entity.Property(e => e.CodeLivreur).HasMaxLength(50);
            entity.Property(e => e.CodeSemaine).HasMaxLength(10);
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.Zone).HasMaxLength(30);
        });

        modelBuilder.Entity<VueOperationProgramme>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_OperationProgramme");

            entity.Property(e => e.DateOperation).HasColumnType("datetime");
            entity.Property(e => e.HeureCreation).HasColumnType("datetime");
            entity.Property(e => e.Nature)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.Opération)
                .HasMaxLength(33)
                .IsUnicode(false);
            entity.Property(e => e.Utilisateur).HasMaxLength(200);
        });

        modelBuilder.Entity<VuePieceClientAreglerFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vue_PieceClientAreglerFinal");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DatePiece)
                .HasColumnType("datetime")
                .HasColumnName("datePiece");
            entity.Property(e => e.MontantPiece).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
        });

        modelBuilder.Entity<VuePieceNonPayerClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_PieceNonPayerClient");

            entity.Property(e => e.CodeClient).HasMaxLength(20);
            entity.Property(e => e.NumeroPiece).HasMaxLength(30);
            entity.Property(e => e.Restant).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.TotalPayee).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.TotalPiece).HasColumnType("numeric(38, 3)");
        });

        modelBuilder.Entity<VuePieceNonPayerClientParDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_PieceNonPayerClientParDate");

            entity.Property(e => e.CodeClient).HasMaxLength(20);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Restant).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.TotalPayee).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.TotalPiece).HasColumnType("numeric(38, 3)");
        });

        modelBuilder.Entity<VuePieceValiserRecuperer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_PieceValiserRecuperer");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.DesignationArticle).HasMaxLength(200);
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockAgence).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.StockValise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Traitement)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VueRapportValise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_RapportValise");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(6);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.Entrer).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Libelle).HasMaxLength(60);
            entity.Property(e => e.NumerPiece).HasMaxLength(10);
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Sortie).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueRechercheArticleQuantite>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_RechercheArticleQuantite");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeBarre).HasMaxLength(80);
            entity.Property(e => e.CodeCalibre).HasMaxLength(30);
            entity.Property(e => e.CodeCouleur).HasMaxLength(30);
            entity.Property(e => e.CodeDepot).HasMaxLength(13);
            entity.Property(e => e.CodeEtui).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.CodeSexe).HasMaxLength(1);
            entity.Property(e => e.CodeType).HasMaxLength(6);
            entity.Property(e => e.CodeUnite).HasMaxLength(6);
            entity.Property(e => e.DernierPrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("DernierPrixAchatHT");
            entity.Property(e => e.DernierPrixDevise).HasColumnType("numeric(18, 5)");
            entity.Property(e => e.DernierTauxRemise).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.FamilleArticle)
                .HasMaxLength(60)
                .HasColumnName("Famille_Article");
            entity.Property(e => e.Marge).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.MarqueArticle)
                .HasMaxLength(60)
                .HasColumnName("Marque_Article");
            entity.Property(e => e.PrixAchatHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixAchatHT");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteTTC");
            entity.Property(e => e.Quantite).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Reference).HasMaxLength(30);
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
            entity.Property(e => e.TypeArticle).HasMaxLength(60);
            entity.Property(e => e.UniteArticle)
                .HasMaxLength(60)
                .HasColumnName("Unite_Article");
        });

        modelBuilder.Entity<VueReglementNonCloture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueReglementNonCloture");

            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Libelle).HasMaxLength(60);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomUtilisateur).HasMaxLength(20);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<VueReglementNonImpayeEtNonRemplace>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_ReglementNonImpayeEtNonRemplace");

            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.LibelleCompte).HasMaxLength(50);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<VueSoldeClientfinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vue_soldeClientfinal");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.TotalCredit)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("totalCredit");
            entity.Property(e => e.TotalDebit)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("totalDebit");
        });

        modelBuilder.Entity<VueStockGlobal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_StockGlobal");

            entity.Property(e => e.Amine)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMINE");
            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.DepotCentral).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.Firas)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("FIRAS");
            entity.Property(e => e.Stockglobal)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("STOCKGLOBAL");
            entity.Property(e => e.Wassim)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("WASSIM");
        });

        modelBuilder.Entity<VueStockLivreur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_StockLivreur");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeBarre).HasMaxLength(80);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.CodeTva)
                .HasMaxLength(1)
                .HasColumnName("CodeTVA");
            entity.Property(e => e.CodeType).HasMaxLength(6);
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.MarqueArticle).HasMaxLength(60);
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteTTC");
            entity.Property(e => e.Quantite).HasColumnType("numeric(38, 3)");
        });

        modelBuilder.Entity<VueSuivieBonCommande>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_SuivieBonCommande");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateBonCommandeVente).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.DesignationArticle).HasMaxLength(200);
            entity.Property(e => e.Expr1).HasMaxLength(10);
            entity.Property(e => e.Libelle).HasMaxLength(30);
            entity.Property(e => e.MontantFodec).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantHT");
            entity.Property(e => e.MontantRemise).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTTC");
            entity.Property(e => e.MontantTva)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantTVA");
            entity.Property(e => e.NetHt)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("NetHT");
            entity.Property(e => e.NumeroBonCommandeVente).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.Observation).HasMaxLength(1500);
            entity.Property(e => e.PrixAchatNet).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 5)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.QteCommandee).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.QteLivree).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.QteRestante).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.QuantitePossible).HasColumnType("numeric(38, 3)");
            entity.Property(e => e.QuantiteStock).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.ReferenceClient).HasMaxLength(20);
            entity.Property(e => e.TauxRemise).HasColumnType("numeric(9, 2)");
            entity.Property(e => e.TauxTva)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TauxTVA");
        });

        modelBuilder.Entity<VueSuivieClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueSuivieClient");

            entity.Property(e => e.Banque).HasMaxLength(60);
            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Compte).HasMaxLength(50);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.ModeReglement).HasMaxLength(60);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumBordereauEscompte).HasMaxLength(10);
            entity.Property(e => e.NumeroBordereau).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Porteur).HasMaxLength(255);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.Restant).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueSuivieClient2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueSuivieClient2");

            entity.Property(e => e.Banque).HasMaxLength(60);
            entity.Property(e => e.Client).HasMaxLength(160);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Compte).HasMaxLength(50);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.ModeReglement).HasMaxLength(60);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumBordereauEscompte).HasMaxLength(10);
            entity.Property(e => e.NumeroBordereau).HasMaxLength(10);
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Porteur).HasMaxLength(255);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.Restant).HasColumnType("numeric(18, 3)");
        });

        modelBuilder.Entity<VueSuivieCommusionSudOptique>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_SuivieCommusionSudOptique");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.CodeLivreur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.DateReglement).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.MontantCommution).HasColumnType("numeric(2, 2)");
            entity.Property(e => e.MontantPieceTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MontantPieceTTC");
            entity.Property(e => e.MontantPrincipal).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NomPrenom).HasMaxLength(200);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.NumeroReglementClient).HasMaxLength(10);
            entity.Property(e => e.RaisonSociale).HasMaxLength(160);
            entity.Property(e => e.Reference).HasMaxLength(20);
            entity.Property(e => e.TauxCommution).HasColumnType("numeric(2, 2)");
            entity.Property(e => e.TypeVente).HasMaxLength(10);
        });

        modelBuilder.Entity<VueSuivieFournisseur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueSuivieFournisseur");

            entity.Property(e => e.Banque).HasMaxLength(60);
            entity.Property(e => e.CodeBanque).HasMaxLength(6);
            entity.Property(e => e.CodeCompte).HasMaxLength(6);
            entity.Property(e => e.CodeFournisseur).HasMaxLength(10);
            entity.Property(e => e.CodeModeReglement).HasMaxLength(6);
            entity.Property(e => e.Compte).HasMaxLength(50);
            entity.Property(e => e.DatePiece).HasColumnType("datetime");
            entity.Property(e => e.Echeance).HasColumnType("datetime");
            entity.Property(e => e.Etat).HasMaxLength(30);
            entity.Property(e => e.Fournisseur).HasMaxLength(60);
            entity.Property(e => e.ModeReglement).HasMaxLength(60);
            entity.Property(e => e.MontantRecu).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.NumeroEtat).HasMaxLength(3);
            entity.Property(e => e.NumeroPiece).HasMaxLength(10);
            entity.Property(e => e.Reference).HasMaxLength(20);
        });

        modelBuilder.Entity<VueSuivieMouvementStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_SuivieMouvementStock");

            entity.Property(e => e.CodeArticle).HasMaxLength(30);
            entity.Property(e => e.CodeFamille).HasMaxLength(16);
            entity.Property(e => e.CodeMarque).HasMaxLength(6);
            entity.Property(e => e.DateDernierVente).HasColumnType("datetime");
            entity.Property(e => e.Designation).HasMaxLength(300);
            entity.Property(e => e.LibelleFamille).HasMaxLength(60);
            entity.Property(e => e.LibelleMarque).HasMaxLength(60);
            entity.Property(e => e.NumeroBonLivraisonVente).HasMaxLength(10);
            entity.Property(e => e.PrixVenteHt)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteHT");
            entity.Property(e => e.PrixVenteTtc)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PrixVenteTTC");
            entity.Property(e => e.Qtachat)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTAchat");
            entity.Property(e => e.QtstockActuel)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTStockActuel");
            entity.Property(e => e.Qtvente)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QTVente");
        });

        modelBuilder.Entity<VueTotalCreditClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_TotalCreditClient");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(38, 3)");
        });

        modelBuilder.Entity<VueTotalCreditClientFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vue_TotalCreditClientFinal");

            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.TotalRecu).HasColumnType("numeric(38, 3)");
        });

        modelBuilder.Entity<VueTvafacturesVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VueTVAFacturesVente");

            entity.Property(e => e.Base0).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Base12).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Base18).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.Base6).HasColumnType("numeric(18, 3)");
            entity.Property(e => e.CodeClient).HasMaxLength(10);
            entity.Property(e => e.DateFactureVente).HasColumnType("datetime");
            entity.Property(e => e.NumeroFactureVente).HasMaxLength(10);
            entity.Property(e => e.TimbreFiscal).HasColumnType("numeric(9, 3)");
            entity.Property(e => e.TotalTtc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TotalTTC");
            entity.Property(e => e.Tva12)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TVA12");
            entity.Property(e => e.Tva18)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TVA18");
            entity.Property(e => e.Tva6)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TVA6");
        });

        modelBuilder.Entity<ZoneClient>(entity =>
        {
            entity.HasKey(e => e.CodeZoneClient);

            entity.ToTable("ZoneClient");

            entity.Property(e => e.CodeZoneClient).HasMaxLength(10);
            entity.Property(e => e.Libelle).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
