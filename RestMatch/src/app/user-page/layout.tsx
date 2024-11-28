'use client';

import { imageUrl } from "@/utils/constants";
import classes from "./layout.module.scss";
import { useState } from "react";
import { useRouter } from "next/navigation";

const UserLayout = ({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) => {
  const [noPadding, setNoPadding] = useState(1);
  const router = useRouter();

  const changePage = (path: string, btnId: number) => {
    router.replace(path);

    
    setNoPadding(btnId); 
  }

  return (
    <div className="hidden md:flex min-h-[calc(100vh-67px)]">
      <div className="bg-[#A98660] min-w-[441px] pt-12 flex flex-col items-center shadow-lg shadow-gray-500/50">
        <img
          src={`${imageUrl}/userpage/default-user-profile-image.png`}
          className="rounded-full w-[245px] h-[245px] mb-12"
        />
        <h3 className="font-bold mb-12">Sweet Cake</h3>
        <div className="w-full flex flex-col gap-12 text-lg font-bold">
          <div
            className={`${classes["parent-div"]} px-12 ${
              noPadding === 1 && classes["no-padding"]
            } w-full`}
          >
            <button
              className={`${classes["selected-page-button"]} ${
                noPadding === 1 && classes["no-padding"]
              } ${noPadding === 1 && classes.active} h-12 w-full text-left border-b-2`}
              onClick={() => changePage("/user-page/profile", 1)}
            >
              Profile
            </button>
          </div>
          <div
            className={`${classes["parent-div"]} px-12 ${
              noPadding === 2 && classes["no-padding"]
            } ${noPadding === 2 && classes.active} w-full`}
          >
            <button
              className={`${classes["selected-page-button"]} ${
                noPadding === 2 && classes["no-padding"]
              } ${noPadding === 2 && classes.active} h-12 w-full text-left border-b-2`}
              onClick={() => changePage("/user-page/saved-places", 2)}
            >
              My saved places
            </button>
          </div>
          <div
            className={`${classes["parent-div"]} px-12 ${
              noPadding === 3 && classes["no-padding"]
            } w-full`}
          >
            <button
              className={`${classes["selected-page-button"]} ${
                noPadding === 3 && classes["no-padding"]
              } ${noPadding === 3 && classes.active} h-12 w-full text-left border-b-2`}
              onClick={() => changePage("/user-page/saved-preferences", 3)}
            >
              Change preferences
            </button>
          </div>
          <div
            className={`${classes["parent-div"]} px-12 ${
              noPadding === 4 && classes["no-padding"]
            } w-full`}
          >
            <button
              className={`${classes["selected-page-button"]} ${
                noPadding === 4 && classes["no-padding"]
              } ${noPadding === 4 && classes.active} h-12 w-full text-left border-b-2`}
              onClick={() => setNoPadding(4)}
            >
              Password
            </button>
          </div>
        </div>
      </div>
      {children}
    </div>
  );
};

export default UserLayout;
