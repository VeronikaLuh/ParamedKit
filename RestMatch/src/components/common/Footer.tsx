import { Routes } from "@/types/routes";
import { useRouter } from "next/navigation";

const Footer = () => {
    const router = useRouter();
  
    const basicPages = [
      {route: Routes.HOME, name: 'Home'},
      {route: Routes.MATCH, name: 'Match'},
      {route: Routes.SEARCH, name: 'Search'},
      {route: Routes.FAQS, name: 'FAQs'},
      {route: Routes.ABOUT_US, name: 'About'},
    ]
  
    const handleRouteChange = async (url: Routes) => {
      router.push(url);
    }
  return (
    <div>
      <div>
        <div className="w-full h-1 shadow-[0px_4px_4px_rgba(0,0,0,0.25)] mb-10"></div>
      </div>
      <div className="px-7 mb-4">
        <div className="flex flex-row justify-between max-custom:flex-col max-w-[50rem] mb-10 mx-auto text-[1.75rem]">
        {basicPages.map((page, index) => (
            <button key={index} onClick={() => handleRouteChange(page.route)}>{page.name}</button>
          ))}
        </div>
        <div className="w-full border-t-[1px] mb-7"></div>
        <h3 className="text-[1.75rem] text-center">
          @ 2024 RestMatch company, Inc.
        </h3>
      </div>
    </div>
  );
};

export default Footer;
