﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ImportMoviePosters
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MovielensEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MovielensEntities object using the connection string found in the 'MovielensEntities' section of the application configuration file.
        /// </summary>
        public MovielensEntities() : base("name=MovielensEntities", "MovielensEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MovielensEntities object.
        /// </summary>
        public MovielensEntities(string connectionString) : base(connectionString, "MovielensEntities")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MovielensEntities object.
        /// </summary>
        public MovielensEntities(EntityConnection connection) : base(connection, "MovielensEntities")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Movie> Movie
        {
            get
            {
                if ((_Movie == null))
                {
                    _Movie = base.CreateObjectSet<Movie>("Movie");
                }
                return _Movie;
            }
        }
        private ObjectSet<Movie> _Movie;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Rating> Rating
        {
            get
            {
                if ((_Rating == null))
                {
                    _Rating = base.CreateObjectSet<Rating>("Rating");
                }
                return _Rating;
            }
        }
        private ObjectSet<Rating> _Rating;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> User
        {
            get
            {
                if ((_User == null))
                {
                    _User = base.CreateObjectSet<User>("User");
                }
                return _User;
            }
        }
        private ObjectSet<User> _User;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Movie EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMovie(Movie movie)
        {
            base.AddObject("Movie", movie);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Rating EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRating(Rating rating)
        {
            base.AddObject("Rating", rating);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the User EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUser(User user)
        {
            base.AddObject("User", user);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MovielensModel", Name="Movie")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Movie : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Movie object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="unknown">Initial value of the Unknown property.</param>
        /// <param name="action">Initial value of the Action property.</param>
        /// <param name="adventure">Initial value of the Adventure property.</param>
        /// <param name="animation">Initial value of the Animation property.</param>
        /// <param name="childrens">Initial value of the Childrens property.</param>
        /// <param name="comedy">Initial value of the Comedy property.</param>
        /// <param name="crime">Initial value of the Crime property.</param>
        /// <param name="documentary">Initial value of the Documentary property.</param>
        /// <param name="drama">Initial value of the Drama property.</param>
        /// <param name="fantasy">Initial value of the Fantasy property.</param>
        /// <param name="film_Noir">Initial value of the Film_Noir property.</param>
        /// <param name="horror">Initial value of the Horror property.</param>
        /// <param name="musical">Initial value of the Musical property.</param>
        /// <param name="mystery">Initial value of the Mystery property.</param>
        /// <param name="romance">Initial value of the Romance property.</param>
        /// <param name="sci_Fi">Initial value of the Sci_Fi property.</param>
        /// <param name="thriller">Initial value of the Thriller property.</param>
        /// <param name="war">Initial value of the War property.</param>
        /// <param name="western">Initial value of the Western property.</param>
        public static Movie CreateMovie(global::System.Int32 id, global::System.Boolean unknown, global::System.Boolean action, global::System.Boolean adventure, global::System.Boolean animation, global::System.Boolean childrens, global::System.Boolean comedy, global::System.Boolean crime, global::System.Boolean documentary, global::System.Boolean drama, global::System.Boolean fantasy, global::System.Boolean film_Noir, global::System.Boolean horror, global::System.Boolean musical, global::System.Boolean mystery, global::System.Boolean romance, global::System.Boolean sci_Fi, global::System.Boolean thriller, global::System.Boolean war, global::System.Boolean western)
        {
            Movie movie = new Movie();
            movie.Id = id;
            movie.Unknown = unknown;
            movie.Action = action;
            movie.Adventure = adventure;
            movie.Animation = animation;
            movie.Childrens = childrens;
            movie.Comedy = comedy;
            movie.Crime = crime;
            movie.Documentary = documentary;
            movie.Drama = drama;
            movie.Fantasy = fantasy;
            movie.Film_Noir = film_Noir;
            movie.Horror = horror;
            movie.Musical = musical;
            movie.Mystery = mystery;
            movie.Romance = romance;
            movie.Sci_Fi = sci_Fi;
            movie.Thriller = thriller;
            movie.War = war;
            movie.Western = western;
            return movie;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Release_Date
        {
            get
            {
                return _Release_Date;
            }
            set
            {
                OnRelease_DateChanging(value);
                ReportPropertyChanging("Release_Date");
                _Release_Date = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Release_Date");
                OnRelease_DateChanged();
            }
        }
        private global::System.String _Release_Date;
        partial void OnRelease_DateChanging(global::System.String value);
        partial void OnRelease_DateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Video_Release_Date
        {
            get
            {
                return _Video_Release_Date;
            }
            set
            {
                OnVideo_Release_DateChanging(value);
                ReportPropertyChanging("Video_Release_Date");
                _Video_Release_Date = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Video_Release_Date");
                OnVideo_Release_DateChanged();
            }
        }
        private global::System.String _Video_Release_Date;
        partial void OnVideo_Release_DateChanging(global::System.String value);
        partial void OnVideo_Release_DateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String IMDBUrl
        {
            get
            {
                return _IMDBUrl;
            }
            set
            {
                OnIMDBUrlChanging(value);
                ReportPropertyChanging("IMDBUrl");
                _IMDBUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("IMDBUrl");
                OnIMDBUrlChanged();
            }
        }
        private global::System.String _IMDBUrl;
        partial void OnIMDBUrlChanging(global::System.String value);
        partial void OnIMDBUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Unknown
        {
            get
            {
                return _Unknown;
            }
            set
            {
                OnUnknownChanging(value);
                ReportPropertyChanging("Unknown");
                _Unknown = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Unknown");
                OnUnknownChanged();
            }
        }
        private global::System.Boolean _Unknown;
        partial void OnUnknownChanging(global::System.Boolean value);
        partial void OnUnknownChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Action
        {
            get
            {
                return _Action;
            }
            set
            {
                OnActionChanging(value);
                ReportPropertyChanging("Action");
                _Action = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Action");
                OnActionChanged();
            }
        }
        private global::System.Boolean _Action;
        partial void OnActionChanging(global::System.Boolean value);
        partial void OnActionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Adventure
        {
            get
            {
                return _Adventure;
            }
            set
            {
                OnAdventureChanging(value);
                ReportPropertyChanging("Adventure");
                _Adventure = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Adventure");
                OnAdventureChanged();
            }
        }
        private global::System.Boolean _Adventure;
        partial void OnAdventureChanging(global::System.Boolean value);
        partial void OnAdventureChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Animation
        {
            get
            {
                return _Animation;
            }
            set
            {
                OnAnimationChanging(value);
                ReportPropertyChanging("Animation");
                _Animation = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Animation");
                OnAnimationChanged();
            }
        }
        private global::System.Boolean _Animation;
        partial void OnAnimationChanging(global::System.Boolean value);
        partial void OnAnimationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Childrens
        {
            get
            {
                return _Childrens;
            }
            set
            {
                OnChildrensChanging(value);
                ReportPropertyChanging("Childrens");
                _Childrens = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Childrens");
                OnChildrensChanged();
            }
        }
        private global::System.Boolean _Childrens;
        partial void OnChildrensChanging(global::System.Boolean value);
        partial void OnChildrensChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Comedy
        {
            get
            {
                return _Comedy;
            }
            set
            {
                OnComedyChanging(value);
                ReportPropertyChanging("Comedy");
                _Comedy = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Comedy");
                OnComedyChanged();
            }
        }
        private global::System.Boolean _Comedy;
        partial void OnComedyChanging(global::System.Boolean value);
        partial void OnComedyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Crime
        {
            get
            {
                return _Crime;
            }
            set
            {
                OnCrimeChanging(value);
                ReportPropertyChanging("Crime");
                _Crime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Crime");
                OnCrimeChanged();
            }
        }
        private global::System.Boolean _Crime;
        partial void OnCrimeChanging(global::System.Boolean value);
        partial void OnCrimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Documentary
        {
            get
            {
                return _Documentary;
            }
            set
            {
                OnDocumentaryChanging(value);
                ReportPropertyChanging("Documentary");
                _Documentary = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Documentary");
                OnDocumentaryChanged();
            }
        }
        private global::System.Boolean _Documentary;
        partial void OnDocumentaryChanging(global::System.Boolean value);
        partial void OnDocumentaryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Drama
        {
            get
            {
                return _Drama;
            }
            set
            {
                OnDramaChanging(value);
                ReportPropertyChanging("Drama");
                _Drama = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Drama");
                OnDramaChanged();
            }
        }
        private global::System.Boolean _Drama;
        partial void OnDramaChanging(global::System.Boolean value);
        partial void OnDramaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Fantasy
        {
            get
            {
                return _Fantasy;
            }
            set
            {
                OnFantasyChanging(value);
                ReportPropertyChanging("Fantasy");
                _Fantasy = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Fantasy");
                OnFantasyChanged();
            }
        }
        private global::System.Boolean _Fantasy;
        partial void OnFantasyChanging(global::System.Boolean value);
        partial void OnFantasyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Film_Noir
        {
            get
            {
                return _Film_Noir;
            }
            set
            {
                OnFilm_NoirChanging(value);
                ReportPropertyChanging("Film_Noir");
                _Film_Noir = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Film_Noir");
                OnFilm_NoirChanged();
            }
        }
        private global::System.Boolean _Film_Noir;
        partial void OnFilm_NoirChanging(global::System.Boolean value);
        partial void OnFilm_NoirChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Horror
        {
            get
            {
                return _Horror;
            }
            set
            {
                OnHorrorChanging(value);
                ReportPropertyChanging("Horror");
                _Horror = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Horror");
                OnHorrorChanged();
            }
        }
        private global::System.Boolean _Horror;
        partial void OnHorrorChanging(global::System.Boolean value);
        partial void OnHorrorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Musical
        {
            get
            {
                return _Musical;
            }
            set
            {
                OnMusicalChanging(value);
                ReportPropertyChanging("Musical");
                _Musical = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Musical");
                OnMusicalChanged();
            }
        }
        private global::System.Boolean _Musical;
        partial void OnMusicalChanging(global::System.Boolean value);
        partial void OnMusicalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Mystery
        {
            get
            {
                return _Mystery;
            }
            set
            {
                OnMysteryChanging(value);
                ReportPropertyChanging("Mystery");
                _Mystery = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Mystery");
                OnMysteryChanged();
            }
        }
        private global::System.Boolean _Mystery;
        partial void OnMysteryChanging(global::System.Boolean value);
        partial void OnMysteryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Romance
        {
            get
            {
                return _Romance;
            }
            set
            {
                OnRomanceChanging(value);
                ReportPropertyChanging("Romance");
                _Romance = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Romance");
                OnRomanceChanged();
            }
        }
        private global::System.Boolean _Romance;
        partial void OnRomanceChanging(global::System.Boolean value);
        partial void OnRomanceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Sci_Fi
        {
            get
            {
                return _Sci_Fi;
            }
            set
            {
                OnSci_FiChanging(value);
                ReportPropertyChanging("Sci_Fi");
                _Sci_Fi = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Sci_Fi");
                OnSci_FiChanged();
            }
        }
        private global::System.Boolean _Sci_Fi;
        partial void OnSci_FiChanging(global::System.Boolean value);
        partial void OnSci_FiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Thriller
        {
            get
            {
                return _Thriller;
            }
            set
            {
                OnThrillerChanging(value);
                ReportPropertyChanging("Thriller");
                _Thriller = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Thriller");
                OnThrillerChanged();
            }
        }
        private global::System.Boolean _Thriller;
        partial void OnThrillerChanging(global::System.Boolean value);
        partial void OnThrillerChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean War
        {
            get
            {
                return _War;
            }
            set
            {
                OnWarChanging(value);
                ReportPropertyChanging("War");
                _War = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("War");
                OnWarChanged();
            }
        }
        private global::System.Boolean _War;
        partial void OnWarChanging(global::System.Boolean value);
        partial void OnWarChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Western
        {
            get
            {
                return _Western;
            }
            set
            {
                OnWesternChanging(value);
                ReportPropertyChanging("Western");
                _Western = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Western");
                OnWesternChanged();
            }
        }
        private global::System.Boolean _Western;
        partial void OnWesternChanging(global::System.Boolean value);
        partial void OnWesternChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PosterUrl
        {
            get
            {
                return _PosterUrl;
            }
            set
            {
                OnPosterUrlChanging(value);
                ReportPropertyChanging("PosterUrl");
                _PosterUrl = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PosterUrl");
                OnPosterUrlChanged();
            }
        }
        private global::System.String _PosterUrl;
        partial void OnPosterUrlChanging(global::System.String value);
        partial void OnPosterUrlChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MovielensModel", Name="Rating")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Rating : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Rating object.
        /// </summary>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="movieId">Initial value of the MovieId property.</param>
        /// <param name="rating1">Initial value of the Rating1 property.</param>
        public static Rating CreateRating(global::System.Int32 userId, global::System.Int32 movieId, global::System.Int32 rating1)
        {
            Rating rating = new Rating();
            rating.UserId = userId;
            rating.MovieId = movieId;
            rating.Rating1 = rating1;
            return rating;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MovieId
        {
            get
            {
                return _MovieId;
            }
            set
            {
                if (_MovieId != value)
                {
                    OnMovieIdChanging(value);
                    ReportPropertyChanging("MovieId");
                    _MovieId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MovieId");
                    OnMovieIdChanged();
                }
            }
        }
        private global::System.Int32 _MovieId;
        partial void OnMovieIdChanging(global::System.Int32 value);
        partial void OnMovieIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Rating1
        {
            get
            {
                return _Rating1;
            }
            set
            {
                if (_Rating1 != value)
                {
                    OnRating1Changing(value);
                    ReportPropertyChanging("Rating1");
                    _Rating1 = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Rating1");
                    OnRating1Changed();
                }
            }
        }
        private global::System.Int32 _Rating1;
        partial void OnRating1Changing(global::System.Int32 value);
        partial void OnRating1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Timestamp
        {
            get
            {
                return _Timestamp;
            }
            set
            {
                OnTimestampChanging(value);
                ReportPropertyChanging("Timestamp");
                _Timestamp = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Timestamp");
                OnTimestampChanged();
            }
        }
        private Nullable<global::System.Int32> _Timestamp;
        partial void OnTimestampChanging(Nullable<global::System.Int32> value);
        partial void OnTimestampChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MovielensModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static User CreateUser(global::System.Int32 id)
        {
            User user = new User();
            user.Id = id;
            return user;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Age
        {
            get
            {
                return _Age;
            }
            set
            {
                OnAgeChanging(value);
                ReportPropertyChanging("Age");
                _Age = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Age");
                OnAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _Age;
        partial void OnAgeChanging(Nullable<global::System.Int32> value);
        partial void OnAgeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Occupation
        {
            get
            {
                return _Occupation;
            }
            set
            {
                OnOccupationChanging(value);
                ReportPropertyChanging("Occupation");
                _Occupation = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Occupation");
                OnOccupationChanged();
            }
        }
        private global::System.String _Occupation;
        partial void OnOccupationChanging(global::System.String value);
        partial void OnOccupationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Zipcode
        {
            get
            {
                return _Zipcode;
            }
            set
            {
                OnZipcodeChanging(value);
                ReportPropertyChanging("Zipcode");
                _Zipcode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Zipcode");
                OnZipcodeChanged();
            }
        }
        private global::System.String _Zipcode;
        partial void OnZipcodeChanging(global::System.String value);
        partial void OnZipcodeChanged();

        #endregion

    
    }

    #endregion

    
}