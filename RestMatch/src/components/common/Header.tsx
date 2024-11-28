import React, {useEffect, useState} from "react";
import {imageUrl} from "@/utils/constants";
import Image from "next/image";
import styles from "./header.module.scss";
import {usePathname, useRouter} from "next/navigation";
import {Routes} from "@/types/routes";
import authService from "@/services/auth.service";

const Header = () => {
  const router = useRouter();
  const pathname = usePathname();

  const [selectedRoute, setSelectedRoute] = useState<string>('');

  const basicPages = [
    {route: Routes.HOME, name: 'Home page'},
    {route: Routes.MATCH, name: 'Let\'s match'},
    {route: Routes.SEARCH, name: 'Research'},
    // {route: Routes.ABOUT_US, name: 'About us'},
  ]

  const handleRouteChange = async (url: Routes) => {
    router.push(url);
  }

  useEffect(() => {
    setSelectedRoute(`/${pathname.split('/')[1]}`)
  }, [pathname]);

  const isSelected = (route: Routes) => {
    if (route === selectedRoute) {
      return styles.selectedButton
    }
  }

  return (
    <header className="bg-[#352414] fixed top-0 left-0 right-0 h-[67px] w-full pt-[12px] pb-[15px] px-3 z-[110]">
      <div className="flex justify-between h-full">
        <Image
          width="139"
          height="34"
          src={`${imageUrl}/header/logo.png`}
          alt="logo"
        />
        <div className="flex gap-[27px]">
          {basicPages.map((page, index) => (
            <button key={index} onClick={() => handleRouteChange(page.route)}
                    className={`${styles.headerButton} ${isSelected(page.route)}`}>{page.name}</button>
          ))}
        </div>
        {authService.isAuth() ? (
          <button onClick={() => handleRouteChange(Routes.PROFILE)}
                  className={`${styles.headerButton} ${isSelected(Routes.PROFILE)}`}>Profile
          </button>
        ) : (
          <button onClick={() => handleRouteChange(Routes.SIGN_UP)}
                  className={`${styles.headerButton} ${isSelected(Routes.LOGIN)}`}>Register
          </button>
        )
        }
      </div>
    </header>
  );
};

export default Header;
