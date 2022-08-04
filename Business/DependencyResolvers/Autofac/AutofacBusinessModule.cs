using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Authentication;
using Business.Repositories.EmailParameterRepository;
using Business.Repositories.OperationClaimRepository;
using Business.Repositories.UserOperationClaimRepository;
using Business.Repositories.UserRepository;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Repositories.EmailParameterRepository;
using DataAccess.Repositories.OperationClaimRepository;
using DataAccess.Repositories.UserOperationClaimRepository;
using Business.Repositories.AnakartRepository;
using DataAccess.Repositories.AnakartRepository;
using Business.Repositories.CpuRepository;
using DataAccess.Repositories.CpuRepository;
using Business.Repositories.EkranKartiRepository;
using DataAccess.Repositories.EkranKartiRepository;
using Business.Repositories.FirmaRepository;
using DataAccess.Repositories.FirmaRepository;
using Business.Repositories.IsletimSistemiRepository;
using DataAccess.Repositories.IsletimSistemiRepository;
using Business.Repositories.KategoriRepository;
using DataAccess.Repositories.KategoriRepository;
using Business.Repositories.MarkaModelRepository;
using DataAccess.Repositories.MarkaModelRepository;
using Business.Repositories.UrunRepository;
using DataAccess.Repositories.UrunRepository;
using Business.Repositories.VerilenRepository;
using DataAccess.Repositories.VerilenRepository;
using DataAccess.Repositories.UserRepository;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<EmailParameterManager>().As<IEmailParameterService>();
            builder.RegisterType<EfEmailParameterDal>().As<IEmailParameterDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<TokenHandler>().As<ITokenHandler>();

            builder.RegisterType<AnakartManager>().As<IAnakartService>().SingleInstance();
            builder.RegisterType<EfAnakartDal>().As<IAnakartDal>().SingleInstance();

            builder.RegisterType<CpuManager>().As<ICpuService>().SingleInstance();
            builder.RegisterType<EfCpuDal>().As<ICpuDal>().SingleInstance();

            builder.RegisterType<EkranKartiManager>().As<IEkranKartiService>().SingleInstance();
            builder.RegisterType<EfEkranKartiDal>().As<IEkranKartiDal>().SingleInstance();

            builder.RegisterType<FirmaManager>().As<IFirmaService>().SingleInstance();
            builder.RegisterType<EfFirmaDal>().As<IFirmaDal>().SingleInstance();

            builder.RegisterType<IsletimSistemiManager>().As<IIsletimSistemiService>().SingleInstance();
            builder.RegisterType<EfIsletimSistemiDal>().As<IIsletimSistemiDal>().SingleInstance();

            builder.RegisterType<KategoriManager>().As<IKategoriService>().SingleInstance();
            builder.RegisterType<EfKategoriDal>().As<IKategoriDal>().SingleInstance();

            builder.RegisterType<MarkaModelManager>().As<IMarkaModelService>().SingleInstance();
            builder.RegisterType<EfMarkaModelDal>().As<IMarkaModelDal>().SingleInstance();

            builder.RegisterType<UrunManager>().As<IUrunService>().SingleInstance();
            builder.RegisterType<EfUrunDal>().As<IUrunDal>().SingleInstance();

            builder.RegisterType<VerilenManager>().As<IVerilenService>().SingleInstance();
            builder.RegisterType<EfVerilenDal>().As<IVerilenDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new Castle.DynamicProxy.ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
