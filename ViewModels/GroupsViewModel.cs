using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
// using MasterDetailDisplayDataListViewInDesign.Abstractions;
// using MainWinMasterUcDetailUcSwithFrm02.ViewModels
using MainWinMasterUcDetailUcSwithFrm02.Models;
using MainWinMasterUcDetailUcSwithFrm02.Repositories;
using MainWinMasterUcDetailUcSwithFrm02.Commands;
using MainWinMasterUcDetailUcSwithFrm02.View.View;
using System.Diagnostics;


namespace MainWinMasterUcDetailUcSwithFrm02.ViewModels
{
    public class GroupsViewModel : BaseVM
    {
        public ObservableCollection<Group> Groups { get; set; }

        public GroupRepository groupRepository; 

        public GroupsViewModel()
        {
            groupRepository = new GroupRepository();
            
            LoadData();
            SelectedGroup = Groups[2];
        }

        #region Title свойство
        private string title = "Title test";

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        #endregion

        #region SelectedGroup        
        private Group selectedGroup;

        public Group SelectedGroup
        {
            get { return selectedGroup; }
            set 
            {
                selectedGroup = value;
                ChangeCurrentView("Detail");
                RaisePropertyChanged(nameof(SelectedGroup));
            }
        }
        #endregion


        private object detailView;

        public object DetailView
        {
            get { return detailView; }
            set 
            {
                detailView = value;
                RaisePropertyChanged(nameof(DetailView));
            }
        }


        #region Command TestCommand - Тестовая команда
        /// <summary>Тестовая команда</summary>
        private ICommand _TestCommand;

        /// <summary>Тестовая команда</summary>
        public ICommand TestCommand
        {
            get
            {
                if (_TestCommand == null)
                {
                    _TestCommand = new LambdaCommand(OnTestCommandExecuted, CanTestCommandExecute);
                }
                return _TestCommand;
            }
        }

        /// <summary>Проверка возможности выполнения - Тестовая команда</summary>
        private bool CanTestCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Тестовая команда</summary>
        private void OnTestCommandExecuted(object p)
        {
            //var value = _UserDialog.GetStringValue("Введите строку", "123", "Значение по умолчанию");
            //_UserDialog.ShowInformation($"Введено: {value}", "123");

            Debug.WriteLine("MainWindowViewModel--OnTestCommandExecuted(object p)");
        }
        #endregion


        public void LoadData()
        {
            // Groups = (ObservableCollection<Group>)groupRepository.GetAll();
            Groups = new ObservableCollection<Group>(groupRepository.GetAll());
        }

        public void ChangeCurrentView(string viewType)
        {
            switch (viewType)
            {
                case "Detail":
                    GroupViewModel gVM = new GroupViewModel(selectedGroup);
                    GroupDetailView gV = new GroupDetailView();
                    //привязка
                    gV.DataContext = gVM;
                    //отображение
                    this.DetailView = gV;
                    break;
                
                    //default: 
                //    Debug.WriteLine("dffdfdf");
                    
            }
        }

    }
}
