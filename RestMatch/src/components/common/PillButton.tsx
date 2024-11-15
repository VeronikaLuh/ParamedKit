"use client";

import { ReactElement, useState } from "react";
import styles from "./pill-button.module.scss";

interface PillButtonProps {
  onToggle?: (active: boolean) => void;
  children?: ReactElement | string;
}

const PillButton = (props: PillButtonProps) => {
  const { onToggle, children } = props;
  const [active, setActive] = useState(false);

  return (
    <>
      <button
        className={`text-nowrap ${styles.pillButton} ${
          active ? styles.pillButtonActive : ""
        }`}
        onClick={() => {
          setActive(!active);
          if (onToggle) {
            onToggle(active);
          }
        }}
      >
        {children}
      </button>
    </>
  );
};

export default PillButton;
